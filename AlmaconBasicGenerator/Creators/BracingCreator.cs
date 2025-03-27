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
    public class BracingCreator
    {
        public ModelObject CreateBracing(Point startPoint, Point endPoint, double mezzanineHeight)
        {
            var myBracing = new CustomPart(startPoint, endPoint)
            {
                Name = "Bracing column basic systeem",
                Position = new Position
                {
                    Rotation = Position.RotationEnum.TOP,
                    Plane = Position.PlaneEnum.MIDDLE,
                    Depth = Position.DepthEnum.MIDDLE
                },
            };

            myBracing.SetAttribute("P1", "1");
            myBracing.SetAttribute("P2", mezzanineHeight.ToString());
            myBracing.Insert();

            /*
             * P1 == Bout aan voorzijde kolom?
             * P2 == vloerhoogte
             */

            return myBracing;
        }
    }
}