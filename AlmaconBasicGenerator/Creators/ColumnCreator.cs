using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace AlmaconBasicGenerator.Creators
{
    public class ColumnCreator
    {
        public ModelObject CreateColumn(string columnProfile, double mezzanineHeight, string midColumnBool, string endColumnBool, Position.RotationEnum rotationPosition, Point startPoint, Point endPoint)
        {
            var myColumn = new CustomPart(startPoint, endPoint)
            {
                Name = "Kolom basic systeem",
                Position = new Position
                {
                    Rotation = rotationPosition,
                    Plane = Position.PlaneEnum.MIDDLE,
                    Depth = Position.DepthEnum.MIDDLE
                },
            };

            myColumn.SetAttribute("CLM2", columnProfile);
            myColumn.SetAttribute("CLM3", mezzanineHeight.ToString());
            myColumn.SetAttribute("CLM6", midColumnBool);
            myColumn.SetAttribute("CLM8", endColumnBool);
            myColumn.Insert();

            /*
             * CLM2 == Profiel kolom
             * CLM3 == vloerhoogte
             * CLM6 == Middenkolom ja/nee
             * CLM8 == Eindkolom ja/nee
             */

            return myColumn;
        }
    }
}
