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
    public class JoistCreator
    {
        public ModelObject CreateJoist(Point startPoint, Point endPoint, double joistDistance, int thirdJoist, double joistToEndDistance)
        {
            var myJoist = new CustomPart(startPoint, endPoint)
            {
                Name = "Tussenligger set basic systeem",
                Position = new Position
                {
                    Rotation = Position.RotationEnum.TOP,
                    Plane = Position.PlaneEnum.MIDDLE,
                    Depth = Position.DepthEnum.MIDDLE,
                    PlaneOffset = 0,
                    DepthOffset = -41
                },
            };
            myJoist.SetAttribute("JST3",joistDistance);
            myJoist.SetAttribute("JST14", thirdJoist);
            myJoist.SetAttribute("JST9", joistToEndDistance);
            myJoist.Insert();

            /*
             * JST3 = Joist distance
             * JST14 = Make third joist?
             * JST9 = Joist distance to third joist
             */

            return myJoist;
        }
    }
}
