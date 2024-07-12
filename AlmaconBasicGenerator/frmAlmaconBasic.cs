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
using Tekla.Structures.Geometry3d;
using System.Net;
using AlmaconBasicGenerator.Creators;

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
            //Determination of offset by picker class
        }

        private void cmbJoistProfileCS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double restValueX;
            double restValueY;
            double positionX;
            double positionY;
            double columnDistanceX;
            double columnDistanceY;

            double mezzanineHeight = double.Parse(txtHeight.Text);
            double spanX = double.Parse(txtXSpan.Text);
            double spanY = double.Parse(txtYSpan.Text);
            int numberOfSpansX = int.Parse(txtBeamQnt.Text);
            int numberOfSpansY = int.Parse(txtJoistQnt.Text);
            double offsetX = double.Parse(txtXcoordinate.Text);
            double offsetY = double.Parse(txtYcoordinate.Text);
            double offsetZ = double.Parse(txtZcoordinate.Text);

            string columnProfile = "KK100/4";

            Position.RotationEnum edgeColumnPosition;
            Position.RotationEnum middleColumnPosition;
            Position.RotationEnum middleColumnPositionMirrored;

            var gridCreator = new GridCreator();
            var columnCreator = new ColumnCreator();
            var beamCreator = new BeamCreator();
            var originPoint = new Point(offsetX, offsetY, offsetZ);
            var startPoint = new Point();
            var startPointBeam = new Point();
            var column = new CustomPart();
            var columnOffset = new Point();

            columnDistanceX = spanX * numberOfSpansX;
            columnDistanceY = spanY * numberOfSpansY;

            if (rdbXdirection.Checked == true)
            {
                restValueX = 150;
                restValueY = 200;

                edgeColumnPosition = Position.RotationEnum.BELOW;
                middleColumnPositionMirrored = Position.RotationEnum.BACK;
                middleColumnPosition = Position.RotationEnum.FRONT;

                var grid = gridCreator.CreateGrid(mezzanineHeight, restValueX, restValueY, spanX, spanY, numberOfSpansX, numberOfSpansY, offsetX, offsetY, offsetZ);

                for (positionX = 0; positionX <= columnDistanceX; positionX += spanX)
                {
                    for (positionY = 0; positionY <= columnDistanceY; positionY += spanY)
                    {
                        if (positionX != 0 && positionX != columnDistanceX)
                        {
                            if (positionY != 0 && positionY != columnDistanceY)
                            {
                                startPoint = new Point(positionX, positionY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "0", middleColumnPosition, startPoint, endPointColumn);
                                //Middenkolommen maken
                            }
                            else if (positionY == 0)
                            {
                                startPoint = new Point(positionX, positionY+restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }
                            else if (positionY == columnDistanceY)
                            {
                                startPoint = new Point(positionX, positionY-restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }
                        }
                        else if (positionX == 0)
                        {
                            if (positionY != 0 && positionY != columnDistanceY)
                            {
                                startPoint = new Point(positionX+restValueX, positionY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "1", middleColumnPositionMirrored, startPoint, endPointColumn);
                            }

                            else if(positionY == 0)
                            {
                                startPoint = new Point(positionX+restValueX, positionY+restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }

                            else if (positionY == columnDistanceY)
                            {
                                startPoint = new Point(positionX+restValueX, positionY-restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }
                        }

                        else if(positionX == columnDistanceX)
                        {
                            if (positionY != 0 && positionY != columnDistanceY)
                            {
                                startPoint = new Point(positionX-restValueX, positionY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "1", middleColumnPosition, startPoint, endPointColumn);
                            }

                            else if (positionY == 0)
                            {
                                startPoint = new Point(positionX-restValueX, positionY+restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }

                            else if (positionY == columnDistanceY)
                            {
                                startPoint = new Point(positionX- restValueX, positionY-restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }
                        }
                    }
                }

                for(positionX = 0; positionX<columnDistanceX; positionX += spanX)
                {
                    for (positionY = 0; positionY <= columnDistanceY; positionY += spanY)
                    {
                        
                        if (positionY == 0)
                        {
                            startPointBeam = new Point(positionX, positionY+restValueY,mezzanineHeight)+originPoint;
                            var endPointBeam = startPointBeam + new Point(spanX,0,0);
                            var beam = beamCreator.CreateBeam(startPointBeam,endPointBeam,-1);
                        }

                        else if(positionY == columnDistanceY)
                        {
                            startPointBeam = new Point(positionX, positionY-restValueY, mezzanineHeight)+originPoint;
                            var endPointBeam = startPointBeam + new Point(spanX, 0, 0);
                            var beam = beamCreator.CreateBeam(startPointBeam, endPointBeam,-1);
                        }

                        else
                        {
                            startPointBeam = new Point(positionX, positionY, mezzanineHeight) + originPoint;
                            var endPointBeam = startPointBeam + new Point(spanX, 0, 0);
                            var beam = beamCreator.CreateBeam(startPointBeam, endPointBeam, 1);
                            beam = beamCreator.CreateBeam(endPointBeam, startPointBeam, 1);
                        }
                    }
                }
            }

            else
            {
                restValueX = 200;
                restValueY = 150;

                edgeColumnPosition = Position.RotationEnum.FRONT;
                middleColumnPositionMirrored = Position.RotationEnum.TOP;
                middleColumnPosition = Position.RotationEnum.BELOW;

                var grid = gridCreator.CreateGrid(mezzanineHeight, restValueX, restValueY, spanX, spanY, numberOfSpansX, numberOfSpansY, offsetX, offsetY, offsetZ);

                for (positionX = 0; positionX <= columnDistanceX; positionX += spanX)
                {
                    for (positionY = 0; positionY <= columnDistanceY; positionY += spanY)
                    {
                        if (positionX != 0 && positionX != columnDistanceX)
                        {
                            if (positionY != 0 && positionY != columnDistanceY)
                            {
                                startPoint = new Point(positionX, positionY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "0", middleColumnPosition, startPoint, endPointColumn);
                                //Middenkolommen maken
                            }
                            else if (positionY == 0)
                            {
                                startPoint = new Point(positionX, positionY + restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "1", middleColumnPosition, startPoint, endPointColumn);
                            }
                            else if (positionY == columnDistanceY)
                            {
                                startPoint = new Point(positionX, positionY - restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "1", "1", middleColumnPositionMirrored, startPoint, endPointColumn);
                            }
                        }

                        else if (positionX == 0)
                        {
                            if (positionY != 0 && positionY != columnDistanceY)
                            {
                                startPoint = new Point(positionX + restValueX, positionY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }

                            else if (positionY == 0)
                            {
                                startPoint = new Point(positionX + restValueX, positionY + restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }

                            else if (positionY == columnDistanceY)
                            {
                                startPoint = new Point(positionX + restValueX, positionY - restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }
                        }

                        else if (positionX == columnDistanceX)
                        {
                            if (positionY != 0 && positionY != columnDistanceY)
                            {
                                startPoint = new Point(positionX - restValueX, positionY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }

                            else if (positionY == 0)
                            {
                                startPoint = new Point(positionX - restValueX, positionY + restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
                            }

                            else if (positionY == columnDistanceY)
                            {
                                startPoint = new Point(positionX - restValueX, positionY - restValueY, 0) + originPoint;
                                var endPointColumn = startPoint + new Point(0, 0, mezzanineHeight);
                                var myColumn = columnCreator.CreateColumn(columnProfile, mezzanineHeight, "0", "0", edgeColumnPosition, startPoint, endPointColumn);
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
                                startPointBeam = new Point(positionX+restValueX, positionY, mezzanineHeight) + originPoint;
                                var endPointBeam = startPointBeam + new Point(0, spanY, 0);
                                var beam = beamCreator.CreateBeam(startPointBeam, endPointBeam, -1);
                            }

                            else if (positionX == columnDistanceX)
                            {
                                startPointBeam = new Point(positionX-restValueX, positionY, mezzanineHeight) + originPoint;
                                var endPointBeam = startPointBeam + new Point(0, spanY, 0);
                                var beam = beamCreator.CreateBeam(startPointBeam, endPointBeam, -1);
                            }

                            else
                            {
                                startPointBeam = new Point(positionX, positionY, mezzanineHeight) + originPoint;
                                var endPointBeam = startPointBeam + new Point(0, spanY, 0);
                                var beam = beamCreator.CreateBeam(startPointBeam, endPointBeam, 1);
                                beam = beamCreator.CreateBeam(endPointBeam, startPointBeam, 1);
                            }
                        }
                    }
                }
            

            Model myModel = new Model();

            if (myModel.GetConnectionStatus())
                myModel.CommitChanges();
        }
    }
}
