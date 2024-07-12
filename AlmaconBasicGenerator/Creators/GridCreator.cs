using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace AlmaconBasicGenerator.Creators
{
    public class GridCreator
    {
        public Grid CreateGrid(double mezzanineHeight, double restValueX, double restValueY, double spanX, double spanY, int numberOfSpansX, int numberOfSpansY, double offsetX, double offsetY, double offsetZ)
        {
            Grid myGrid = new Grid();

            if (numberOfSpansX>2)
            {
                myGrid.CoordinateX = "0 " + restValueX + " " + (spanX - restValueX) + " " + (numberOfSpansX - 2) + "*" + spanX + " " + (spanX - restValueX) + " " + restValueX;
            }
            else
            {
                if (numberOfSpansX == 1)
                {
                    myGrid.CoordinateX = "0 " + restValueX + " " + (spanX - 2 * restValueX) + " " + restValueX;
                }

                else if (numberOfSpansX == 2)
                {
                    myGrid.CoordinateX = "0 " + restValueX + " " + (spanX - restValueX) + " " + (spanX - restValueX) + " " + restValueX;
                }
            }

            if (numberOfSpansY > 2)
            {
                myGrid.CoordinateY = "0 " + restValueY + " " + (spanY - restValueY) + " " + (numberOfSpansY - 2) + "*" + spanY + " " + (spanY - restValueY) + " " + restValueY;
            }

            else
            {
                if (numberOfSpansY == 1)
                {
                    myGrid.CoordinateY = "0 " + restValueY + " " + (spanY - 2 * restValueY) + " " + restValueY;
                }

                else if (numberOfSpansY == 2)
                {
                    myGrid.CoordinateY = "0 " + restValueY + " " + (spanY - restValueY) + " " + (spanY - restValueY) + " " + restValueY;
                }
            }  

            myGrid.CoordinateZ = "0 " + mezzanineHeight;
            myGrid.IsMagnetic = true;

            myGrid.LabelX = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            myGrid.LabelY = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30";
            myGrid.LabelZ = "+0 " + " +" + mezzanineHeight.ToString();

            myGrid.Origin.X = offsetX;
            myGrid.Origin.Y = offsetY;
            myGrid.Origin.Z = offsetZ;

            myGrid.Insert();
            return myGrid;
        }
    }
}
