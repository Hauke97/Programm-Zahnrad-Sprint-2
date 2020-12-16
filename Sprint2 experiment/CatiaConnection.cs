using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFITF;
using MECMOD;
using PARTITF;
using ProductStructureTypeLib;
using HybridShapeTypeLib;
using KnowledgewareTypeLib;
using System.Windows;
using System.Windows.Controls;

namespace Sprint2_experiment
{


    public partial class UserControl1
    {
        
        
        class CatiaConnection
        {
            INFITF.Application hsp_catiaApp;
            MECMOD.PartDocument hsp_catiaPart;
            MECMOD.Sketch hsp_catiaProfil;

            public bool CATIALaeuft()
            {
                try
                {
                    object catiaObject = System.Runtime.InteropServices.Marshal.GetActiveObject(
                        "CATIA.Application");
                    hsp_catiaApp = (INFITF.Application)catiaObject;
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public Boolean ErzeugePart()
            {
                INFITF.Documents catDocuments1 = hsp_catiaApp.Documents;
                hsp_catiaPart = catDocuments1.Add("Part") as MECMOD.PartDocument;
                return true;
            }

            public void ErstelleLeereSkizze()
            {
                // geometrisches Set auswaehlen und umbenennen
                HybridBodies catHybridBodies1 = hsp_catiaPart.Part.HybridBodies;
                HybridBody catHybridBody1;
                try
                {
                    catHybridBody1 = catHybridBodies1.Item("Geometrisches Set.1");
                }
                catch (Exception)
                {
                    MessageBox.Show("Kein geometrisches Set gefunden! " + Environment.NewLine +
                        "Ein PART manuell erzeugen und ein darauf achten, dass 'Geometisches Set' aktiviert ist.",
                        "Fehler", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                catHybridBody1.set_Name("Profile");
                // neue Skizze im ausgewaehlten geometrischen Set anlegen
                Sketches catSketches1 = catHybridBody1.HybridSketches;
                OriginElements catOriginElements = hsp_catiaPart.Part.OriginElements;
                Reference catReference1 = (Reference)catOriginElements.PlaneYZ;
                hsp_catiaProfil = catSketches1.Add(catReference1);

                // Achsensystem in Skizze erstellen 
                ErzeugeAchsensystem();

                // Part aktualisieren
                hsp_catiaPart.Part.Update();
            }

            private void ErzeugeAchsensystem()
            {
                object[] arr = new object[] {0.0, 0.0, 0.0,
                                         0.0, 1.0, 0.0,
                                         0.0, 0.0, 1.0 };
                hsp_catiaProfil.SetAbsoluteAxisData(arr);
            }

            public void ErzeugeProfil(double m, double z, double d)
            {
                Schnittpunkte SP1 = new Schnittpunkte();
                Schnittpunkte SP2 = new Schnittpunkte();
                Schnittpunkte SP3 = new Schnittpunkte();
                SP1.Berechne_Schnittpunkte1(m, z, d);
                SP2.Berechne_Schnittpunkt2(m, z, d);
                SP3.Berechne_Schnittpunkt3(m, z, d);

                // Skizze umbenennen
                hsp_catiaProfil.set_Name("Zahn");

                // Skizze oeffnen
                Factory2D catFactory2D1 = hsp_catiaProfil.OpenEdition();

               

                // Zahn erzeugen
                Point2D catPoint2D1 = catFactory2D1.CreatePoint(SP1.x1, SP1.y1);
                Point2D catPoint2D2 = catFactory2D1.CreatePoint(SP1.x2, SP1.y2);
                Point2D catPoint2D3 = catFactory2D1.CreatePoint(SP2.x3, SP2.y3);
                Point2D catPoint2D4 = catFactory2D1.CreatePoint(SP2.x4, SP2.y4);
                Point2D catPoint2D5 = catFactory2D1.CreatePoint(SP3.x5, SP3.y5);
                Point2D catPoint2D6 = catFactory2D1.CreatePoint(SP3.x6, SP3.y6);

                Line2D catLine2D1 = catFactory2D1.CreateLine(SP1.x1, SP1.y1, SP1.x2, SP1.y2);
                catLine2D1.StartPoint = catPoint2D1;
                catLine2D1.EndPoint = catPoint2D2;

                Line2D catLine2D2 = catFactory2D1.CreateLine(-18.214, 264.863, 18.214, 264.863);
                catLine2D2.StartPoint = catPoint2D2;
                catLine2D2.EndPoint = catPoint2D3;


                Line2D catLine2D3 = catFactory2D1.CreateLine(18.214, 264.863, 18.214, 199.169);
                catLine2D3.StartPoint = catPoint2D3;
                catLine2D3.EndPoint = catPoint2D4;

                Circle2D catCircle2D1 = catFactory2D1.CreateCircle(SP2.X1, SP2.Y1, SP2.R1, 1.347830515, 1.479602873);

                //Zahn mit Kreismuster vervielfältigen
                ShapeFactory SF = (ShapeFactory)hsp_catiaPart.Part.ShapeFactory;
                HybridShapeFactory HSF = (HybridShapeFactory)hsp_catiaPart.Part.HybridShapeFactory;
                Part myPart = hsp_catiaPart.Part;

                Factory2D Factory2D1 = hsp_catiaProfil.Factory2D;
                HybridShapePointCoord Ursprung = HSF.AddNewPointCoord(0, 0, 0);
                Reference RefUrsprung = myPart.CreateReferenceFromObject(Ursprung);
                HybridShapeDirection XDir = HSF.AddNewDirectionByCoord(1, 0, 0);
                Reference RefXDir = myPart.CreateReferenceFromObject(XDir);

                CircPattern Kreismuster = SF.AddNewSurfacicCircPattern(Factory2D1, 1, 2, 0, 0, 1, 1, RefUrsprung, RefXDir, false, 0, true, false);
                Kreismuster.CircularPatternParameters = CatCircularPatternParameters.catInstancesandAngularSpacing;
                AngularRepartition angularRepartition1 = Kreismuster.AngularRepartition;
                Angle angle1 = angularRepartition1.AngularSpacing;
                angle1.Value = Convert.ToDouble(360 / 20);
                AngularRepartition angularRepartition2 = Kreismuster.AngularRepartition;
                IntParam intParam1 = angularRepartition2.InstancesCount;
                intParam1.Value = 20 + 1;

                Reference Ref_Kreismuster = myPart.CreateReferenceFromObject(Kreismuster);
                HybridShapeAssemble Verbindung = HSF.AddNewJoin(Ref_Kreismuster, Ref_Kreismuster);
                Reference Ref_Verbindung = myPart.CreateReferenceFromObject(Verbindung);

                HSF.GSMVisibility(Ref_Verbindung, 0);

                myPart.Update();

                Bodies bodies = myPart.Bodies;
                Body myBody = bodies.Add();
                myBody.set_Name("Zahnrad");
                myBody.InsertHybridShape(Verbindung);

                myPart.Update();

                // Skizzierer verlassen
                hsp_catiaProfil.CloseEdition();
                // Part aktualisieren
                hsp_catiaPart.Part.Update();
            }

            public void ErzeugeZahnrad(double b)
            {
                // Hauptkoerper in Bearbeitung definieren
                hsp_catiaPart.Part.InWorkObject = hsp_catiaPart.Part.MainBody;

                // Block erzeugen
                ShapeFactory catShapeFactory1 = (ShapeFactory)hsp_catiaPart.Part.ShapeFactory;
                Pad catPad1 = catShapeFactory1.AddNewPad(hsp_catiaProfil, b);

                // Block umbenennen
                catPad1.set_Name("Zahnrad");

                // Part aktualisieren
                hsp_catiaPart.Part.Update();
            }
        }

        
    }
}
