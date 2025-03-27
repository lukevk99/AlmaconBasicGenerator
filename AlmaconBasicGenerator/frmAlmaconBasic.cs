using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using Tekla.Structures.Geometry3d;
using System.Net;
using AlmaconBasicGenerator.Creators;
using AlmaconBasicGenerator.DataCollection;
using System.IO;

namespace AlmaconBasicGenerator
{
    public partial class frmAlmaconBasic : Form
    {
        public frmAlmaconBasic()
        {
            InitializeComponent();

        }
        private void btnOrigin_Click(object sender, EventArgs e)
        {
            Tekla.Structures.Model.UI.Picker _picker = new Tekla.Structures.Model.UI.Picker();
            Point originPoint = _picker.PickPoint("Pick the origin point");

            txtXcoordinate.Text = originPoint.X.ToString();
            txtYcoordinate.Text = originPoint.Y.ToString();
            txtZcoordinate.Text = originPoint.Z.ToString();
            //Determination of offset by picker classssss
        }
        public void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkExcelConnection = new CheckExcelConnection();
            if (checkExcelConnection.checkExcelConnection() == "Failed")
            {
                Environment.Exit(0);
            }

            var excelDataCollection = new ExcelDataCollection();
            var excelConfigurator = new GetFilenameConfigurator().ReturnFilename();

            txtHeight.Text = excelDataCollection.CollectData(1, 6, excelConfigurator);
            txtJoistDistance.Text = excelDataCollection.CollectData(4, 6, excelConfigurator);
            txtFloorLoad.Text = excelDataCollection.CollectData(7, 6, excelConfigurator);

            if (rdbXdirection.Checked == true)
            {
                txtXSpan.Text = excelDataCollection.CollectData(2, 6, excelConfigurator);
                txtYSpan.Text = excelDataCollection.CollectData(3, 6, excelConfigurator);
            }

            else
            {
                txtXSpan.Text = excelDataCollection.CollectData(3, 6, excelConfigurator);
                txtYSpan.Text = excelDataCollection.CollectData(2, 6, excelConfigurator);
            }
        }
        private void btnSyncExcelData_Click_1(object sender, EventArgs e)
        {
            var excelDataCollection = new ExcelDataCollection();
            var excelConfigurator = new GetFilenameConfigurator().ReturnFilename();
            txtHeight.Text = excelDataCollection.CollectData(1, 6, excelConfigurator);
            txtJoistDistance.Text = excelDataCollection.CollectData(4, 6, excelConfigurator);
            txtFloorLoad.Text = excelDataCollection.CollectData(7, 6, excelConfigurator);

            if (rdbXdirection.Checked == true)
            {
                txtXSpan.Text = excelDataCollection.CollectData(2, 6, excelConfigurator);
                txtYSpan.Text = excelDataCollection.CollectData(3, 6, excelConfigurator);
            }

            else
            {
                txtXSpan.Text = excelDataCollection.CollectData(3, 6, excelConfigurator);
                txtYSpan.Text = excelDataCollection.CollectData(2, 6, excelConfigurator);
            }
        }
        private void rdbXdirection_CheckedChanged(object sender, EventArgs e)
        {
            var excelDataCollection = new ExcelDataCollection();
            var excelConfigurator = new GetFilenameConfigurator().ReturnFilename();

            txtHeight.Text = excelDataCollection.CollectData(1, 6, excelConfigurator);
            txtJoistDistance.Text = excelDataCollection.CollectData(4, 6, excelConfigurator);
            if (rdbXdirection.Checked == true)
            {
                txtXSpan.Text = excelDataCollection.CollectData(2, 6, excelConfigurator);
                txtYSpan.Text = excelDataCollection.CollectData(3, 6, excelConfigurator);
            }

            else
            {
                txtXSpan.Text = excelDataCollection.CollectData(3, 6, excelConfigurator);
                txtYSpan.Text = excelDataCollection.CollectData(2, 6, excelConfigurator);
            }
        }
        private void cmbJoistProfileCS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtJoistDistance_TextChanged(object sender, EventArgs e)
        {
            joistDistanceErrorPRovider.Clear();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            double restValueX;
            double restValueY;
            double positionX;
            double positionY;
            double columnDistanceX;
            double columnDistanceY;
            double joistDistanceCheck;
            string columnProfile;

            double mezzanineHeight = double.Parse(txtHeight.Text);

            int numberOfSpansX = int.Parse(txtBeamQnt.Text);
            int numberOfSpansY = int.Parse(txtJoistQnt.Text);
            double offsetX = double.Parse(txtXcoordinate.Text);
            double offsetY = double.Parse(txtYcoordinate.Text);
            double offsetZ = double.Parse(txtZcoordinate.Text);
            double joistDistance = double.Parse(txtJoistDistance.Text);
            double joistDistanceInitial = joistDistance - 25;
            joistDistanceCheck = joistDistance / 25 - Math.Round(joistDistance / 25);

            double spanX = double.Parse(txtXSpan.Text);
            double spanY = double.Parse(txtYSpan.Text);
            columnDistanceX = spanX * numberOfSpansX;
            columnDistanceY = spanY * numberOfSpansY;

            Position.RotationEnum edgeColumnPosition;
            Position.RotationEnum edgeColumnPositionMirrored;
            Position.RotationEnum middleColumnPosition;
            Position.RotationEnum middleColumnPositionMirrored;

            var gridCreator = new GridCreator();
            var columnCreator = new ColumnCreator();
            var beamCreator = new BeamCreator();
            var joistCreator = new JoistCreator();
            var bracingCreator = new BracingCreator();
            var originPoint = new Point(offsetX, offsetY, offsetZ);
            var startPoint = new Point();
            var startPointBeam = new Point();
            var column = new CustomPart();
            var columnOffset = new Point();
            var excelSave = new SaveActiveExcel();
            var excelDataCollection = new ExcelDataCollection();
            var excelConfigurator = new GetFilenameConfigurator().ReturnFilename();


            if (excelDataCollection.CollectData(12, 16, excelConfigurator) == "KK100x100x4")
            {
                columnProfile = "KK100/4";
            }

            else
            {
                columnProfile = "KK100/5";
            }

            if (joistDistanceCheck != 0)
            {
                joistDistanceErrorPRovider.SetError(txtJoistDistance, "Tussenliggerafstand moet deelbaar zijn door 25!");
            }
            else
            {
                Model myModel = new Model();

                if (myModel.GetConnectionStatus())
                {

                    //var modelPath = myModel.GetInfo().ModelPath;
                    //var fileName = txtFloorLoad.Text + "kg_m2" + "_" + txtHeight.Text + "_" + txtXSpan.Text + "_" + txtYSpan.Text + "_";
                    //excelSave.saveActiveExcel(modelPath, fileName);
                }
                if (rdbXdirection.Checked == true)
                {
                    //Keuze voor hoofdliggers in X-richting
                    txtHeight.Text = excelDataCollection.CollectData(1, 6, excelConfigurator);
                    txtJoistDistance.Text = excelDataCollection.CollectData(4, 6, excelConfigurator);
                    txtFloorLoad.Text = excelDataCollection.CollectData(7, 6, excelConfigurator);

                    txtXSpan.Text = excelDataCollection.CollectData(2, 6, excelConfigurator);
                    txtYSpan.Text = excelDataCollection.CollectData(3, 6, excelConfigurator);

                    restValueX = 150;
                    restValueY = 200;

                    edgeColumnPosition = Position.RotationEnum.BELOW;
                    edgeColumnPositionMirrored = Position.RotationEnum.TOP;
                    middleColumnPositionMirrored = Position.RotationEnum.BACK;
                    middleColumnPosition = Position.RotationEnum.FRONT;

                    var centerFirstLastJoist = columnDistanceX - 2 * 25;
                    var numberOfJoistSpans = Math.Ceiling((centerFirstLastJoist + 60) / joistDistance);

                    //var grid = gridCreator.CreateGrid(mezzanineHeight, restValueX, restValueY, spanX, spanY, numberOfSpansX, numberOfSpansY, offsetX, offsetY, offsetZ);
                    // maken van kolomstramien

                    for (positionX = 0; positionX <= columnDistanceX; positionX += spanX)
                    {
                        for (positionY = 0; positionY <= columnDistanceY; positionY += spanY)
                        {
                            if (positionX != 0 && positionX != columnDistanceX)
                            {
                                if (positionY != 0 && positionY != columnDistanceY)
                                {
                                    startPoint = new Point(positionX, positionY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "0", middleColumnPosition, startPoint, endPoint);
                                    //Middenkolommen maken
                                }
                                else if (positionY == 0)
                                {
                                    startPoint = new Point(positionX, positionY + restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPositionMirrored, startPoint, endPoint);
                                    //randkolommen onder maken
                                }
                                else if (positionY == columnDistanceY)
                                {
                                    startPoint = new Point(positionX, positionY - restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPoint);
                                    //randkolommen boven maken
                                }
                            }

                            else if (positionX == 0)
                            {
                                if (positionY != 0 && positionY != columnDistanceY)
                                {
                                    startPoint = new Point(positionX + restValueX, positionY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "1", middleColumnPositionMirrored, startPoint, endPoint);
                                    //randkolommen links maken excl. hoekkolommen
                                }

                                else if (positionY == 0)
                                {
                                    startPoint = new Point(positionX + restValueX, positionY + restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPositionMirrored, startPoint, endPoint);
                                    //randkolom linksonder maken
                                    var myBracing = bracingCreator.CreateBracing(startPoint,endPoint,mezzanineHeight);
                                    //Schoorkolom maken hoekkolom linksonder
                                }

                                else if (positionY == columnDistanceY)
                                {
                                    startPoint = new Point(positionX + restValueX, positionY - restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPoint);
                                    //randkolom linksboven maken
                                }
                            }

                            else if (positionX == columnDistanceX)
                            {
                                if (positionY != 0 && positionY != columnDistanceY)
                                {
                                    startPoint = new Point(positionX - restValueX, positionY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "1", middleColumnPosition, startPoint, endPoint);
                                    //randkolommen rechts maken excl. hoekkolommen
                                }

                                else if (positionY == 0)
                                {
                                    startPoint = new Point(positionX - restValueX, positionY + restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPositionMirrored, startPoint, endPoint);
                                    //randkolom rechtsonder maken
                                }

                                else if (positionY == columnDistanceY)
                                {
                                    startPoint = new Point(positionX - restValueX, positionY - restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPoint);
                                    //randkolom rechtsboven maken
                                }
                            }
                        }
                    }

                    for (positionX = 0; positionX < columnDistanceX; positionX += spanX)
                    {
                        for (positionY = 0; positionY <= columnDistanceY; positionY += spanY)
                        {

                            if (positionY == 0)
                            {
                                startPointBeam = new Point(positionX, positionY + restValueY, mezzanineHeight) + originPoint;
                                var endPointBeam = startPointBeam + new Point(spanX, 0, 0);
                                var beam = beamCreator.CreateBeam(endPointBeam, startPointBeam, 100);
                                //Onderste randkolommen hoofdligger maken
                            }

                            else if (positionY == columnDistanceY)
                            {
                                startPointBeam = new Point(positionX, positionY - restValueY, mezzanineHeight) + originPoint;
                                var endPointBeam = startPointBeam + new Point(spanX, 0, 0);
                                var beam = beamCreator.CreateBeam(startPointBeam, endPointBeam, 100);
                                //bovenste randkolommen hoofdligger maken
                            }

                            else
                            {
                                startPointBeam = new Point(positionX, positionY, mezzanineHeight) + originPoint;
                                var endPointBeam = startPointBeam + new Point(spanX, 0, 0);
                                var beam = beamCreator.CreateBeam(startPointBeam, endPointBeam, -102);
                                beam = beamCreator.CreateBeam(endPointBeam, startPointBeam, -102);
                                //middenkolommen hoofdligger set maken
                            }
                        }
                    }

                    for (positionY = 0; positionY <= columnDistanceY - spanY; positionY += spanY)
                    {
                        startPoint = new Point(25, positionY, mezzanineHeight) + originPoint;
                        var endPoint = startPoint + new Point(0, spanY, 0);
                        var myJoist = joistCreator.CreateJoist(startPoint, endPoint, joistDistanceInitial, 0, 2 * joistDistance);
                        //Eerste tussenliggerset plaatsen (onder)

                        for (positionX = 25 + Math.Floor((joistDistance + joistDistanceInitial) / 50) * 50; positionX < columnDistanceX - 25 - joistDistanceInitial - joistDistance; positionX += joistDistance * 2)
                        {
                            startPoint = new Point(positionX, positionY, mezzanineHeight) + originPoint;
                            endPoint = startPoint + new Point(0, spanY, 0);
                            myJoist = joistCreator.CreateJoist(startPoint, endPoint, joistDistance, 0, 2 * joistDistance);
                            //Gelijkmatig verdeelde tussenliggers plaatsen
                        }

                        if (columnDistanceX - 25 - positionX <= 2 * joistDistance - joistDistanceInitial)
                        {
                            startPoint = new Point(Math.Round((columnDistanceX - 25 - joistDistanceInitial) / 50) * 50 - 25, positionY, mezzanineHeight) + originPoint;
                            endPoint = startPoint + new Point(0, spanY, 0);
                            myJoist = joistCreator.CreateJoist(startPoint, endPoint, joistDistanceInitial, 0, 2 * joistDistance);
                            //Laatste tussenliggerset plaatsen (set van 2)
                        }

                        else
                        {
                            startPoint = new Point(Math.Round(positionX / 50) * 50 - 25, positionY, mezzanineHeight) + originPoint;
                            endPoint = startPoint + new Point(0, spanY, 0);
                            myJoist = joistCreator.CreateJoist(startPoint, endPoint, (columnDistanceX - 25 - startPoint.X + originPoint.X) * 0.5, 1, columnDistanceX - 25 - startPoint.X + originPoint.X);
                            //Laatste tussenliggerset plaatsen (set van 3)
                        }
                    }
                }

                else
                {
                    //Keuze voor hoofdliggers in Y-richting
                    txtHeight.Text = excelDataCollection.CollectData(1, 6, excelConfigurator);
                    txtJoistDistance.Text = excelDataCollection.CollectData(4, 6, excelConfigurator);

                    txtXSpan.Text = excelDataCollection.CollectData(3, 6, excelConfigurator);
                    txtYSpan.Text = excelDataCollection.CollectData(2, 6, excelConfigurator);

                    restValueX = 200;
                    restValueY = 150;

                    edgeColumnPosition = Position.RotationEnum.FRONT;
                    edgeColumnPositionMirrored = Position.RotationEnum.BACK;
                    middleColumnPositionMirrored = Position.RotationEnum.TOP;
                    middleColumnPosition = Position.RotationEnum.BELOW;

                    var centerFirstLastJoist = columnDistanceY - 2 * 25;
                    var numberOfJoistSpans = Math.Ceiling((centerFirstLastJoist + 60) / joistDistance);

                    //var grid = gridCreator.CreateGrid(mezzanineHeight, restValueX, restValueY, spanX, spanY, numberOfSpansX, numberOfSpansY, offsetX, offsetY, offsetZ);
                    //Maken kolomstramien
                    for (positionX = 0; positionX <= columnDistanceX; positionX += spanX)
                    {
                        for (positionY = 0; positionY <= columnDistanceY; positionY += spanY)
                        {
                            if (positionX != 0 && positionX != columnDistanceX)
                            {
                                if (positionY != 0 && positionY != columnDistanceY)
                                {
                                    startPoint = new Point(positionX, positionY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "0", middleColumnPosition, startPoint, endPoint);
                                    //Middenkolommen maken
                                }
                                else if (positionY == 0)
                                {
                                    startPoint = new Point(positionX, positionY + restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "1", middleColumnPosition, startPoint, endPoint);
                                    //Randkolommen onder excl. hoekkolommen
                                }
                                else if (positionY == columnDistanceY)
                                {
                                    startPoint = new Point(positionX, positionY - restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "1", middleColumnPositionMirrored, startPoint, endPoint);
                                    //Randkolommen boven excl. hoekkolommen
                                }
                            }

                            else if (positionX == 0)
                            {
                                if (positionY != 0 && positionY != columnDistanceY)
                                {
                                    startPoint = new Point(positionX + restValueX, positionY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPoint);
                                    // Randkolommen links excl. hoekkolommen
                                }

                                else if (positionY == 0)
                                {
                                    startPoint = new Point(positionX + restValueX, positionY + restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPoint);
                                    //Hoekkolom linksonder
                                    var myBracing = bracingCreator.CreateBracing(startPoint, endPoint, mezzanineHeight);
                                    //Schoorkolom maken hoekkolom linksonder
                                }

                                else if (positionY == columnDistanceY)
                                {
                                    startPoint = new Point(positionX + restValueX, positionY - restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPoint);
                                    //Hoekkolom linksboven
                                }
                            }

                            else if (positionX == columnDistanceX)
                            {
                                if (positionY != 0 && positionY != columnDistanceY)
                                {
                                    startPoint = new Point(positionX - restValueX, positionY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPositionMirrored, startPoint, endPoint);
                                    //Randkolommen rechts excl. hoekkolom
                                }

                                else if (positionY == 0)
                                {
                                    startPoint = new Point(positionX - restValueX, positionY + restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPositionMirrored, startPoint, endPoint);
                                    //Hoekkolom rechtsonder
                                }

                                else if (positionY == columnDistanceY)
                                {
                                    startPoint = new Point(positionX - restValueX, positionY - restValueY, 0) + originPoint;
                                    var endPoint = startPoint + new Point(0, 0, mezzanineHeight);
                                    var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPositionMirrored, startPoint, endPoint);
                                    //Hoekkolom rechtsboven
                                }
                            }
                        }
                    }

                    for (positionX = 0; positionX <= columnDistanceX; positionX += spanX)
                    {
                        for (positionY = 0; positionY < columnDistanceY; positionY += spanY)
                        {

                            if (positionX == 0)
                            {
                                startPointBeam = new Point(positionX + restValueX, positionY, mezzanineHeight) + originPoint;
                                var endPointBeam = startPointBeam + new Point(0, spanY, 0);
                                var beam = beamCreator.CreateBeam(startPointBeam, endPointBeam, 100);
                                //Linker randkolommen hoofdligger maken
                            }

                            else if (positionX == columnDistanceX)
                            {
                                startPointBeam = new Point(positionX - restValueX, positionY, mezzanineHeight) + originPoint;
                                var endPointBeam = startPointBeam + new Point(0, spanY, 0);
                                var beam = beamCreator.CreateBeam(endPointBeam, startPointBeam, 100);
                                //Rechter randkolommen hoofdligger maken
                            }

                            else
                            {
                                startPointBeam = new Point(positionX, positionY, mezzanineHeight) + originPoint;
                                var endPointBeam = startPointBeam + new Point(0, spanY, 0);
                                var beam = beamCreator.CreateBeam(startPointBeam, endPointBeam, -102);
                                beam = beamCreator.CreateBeam(endPointBeam, startPointBeam, -102);
                                //Middenkolommen hoofdligger set maken
                            }
                        }
                    }

                    for (positionX = 0; positionX <= columnDistanceX - spanX; positionX += spanX)
                    {
                        startPoint = new Point(positionX, 25, mezzanineHeight) + originPoint;
                        var endPoint = startPoint + new Point(spanX, 0, 0);
                        var myJoist = joistCreator.CreateJoist(endPoint, startPoint, joistDistanceInitial, 0, 2 * joistDistance);
                        //Eerste tussenliggerset plaatsen (links)

                        for (positionY = 25 + Math.Floor((joistDistance + joistDistanceInitial) / 50) * 50; positionY < columnDistanceY - 25 - joistDistanceInitial - joistDistance; positionY += joistDistance * 2)
                        {
                            startPoint = new Point(positionX, positionY, mezzanineHeight) + originPoint;
                            endPoint = startPoint + new Point(spanX, 0, 0);
                            myJoist = joistCreator.CreateJoist(endPoint, startPoint, joistDistance, 0, 2 * joistDistance);
                            //Gelijkmatig verdeelde tussenliggers plaatsen
                        }

                        if (columnDistanceY - 25 - positionY <= 2 * joistDistance - joistDistanceInitial)
                        {
                            startPoint = new Point(positionX, Math.Round((columnDistanceY - 25 - joistDistanceInitial) / 50) * 50 + 25, mezzanineHeight) + originPoint;
                            endPoint = startPoint + new Point(spanX, 0, 0);
                            myJoist = joistCreator.CreateJoist(endPoint, startPoint, joistDistanceInitial, 0, 2 * joistDistance);
                            //Laatste tussenliggerset plaatsen (set van 2)
                        }

                        else
                        {
                            startPoint = new Point(positionX, Math.Round(positionY / 50) * 50 + 25, mezzanineHeight) + originPoint;
                            endPoint = startPoint + new Point(spanX, 0, 0);
                            myJoist = joistCreator.CreateJoist(endPoint, startPoint, (columnDistanceY - 25 - startPoint.Y + originPoint.Y) * 0.5, 1, columnDistanceY - 25 - startPoint.Y+originPoint.Y);
                            //Laatste tussenliggerset plaatsen (set van 3)
                        }
                    }
                }

                myModel.CommitChanges();

                if (Operation.IsNumberingUpToDateAll())
                {
                    MessageBox.Show("De nummering is up-to-date");
                }

                else
                {
                    Operation.RunMacro("CheckAndRepairAll.cs");
                    myModel.CommitChanges();
                    MessageBox.Show("De nummering is up-to-date");
                }
            }
        }
    }
}