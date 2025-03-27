using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace AlmaconBasicGenerator.Creators
{
    public class BeamCreator
    {
        public ModelObject CreateBeam(Point startPoint, Point endPoint, double beamOffset)
        {
            var myBeam = new CustomPart(startPoint, endPoint)
            {
                Name = "Hoofdligger basic systeem",
                Position = new Position
                {
                    Rotation = Position.RotationEnum.TOP,
                    Plane = Position.PlaneEnum.MIDDLE,
                    Depth = Position.DepthEnum.MIDDLE,
                    PlaneOffset = beamOffset,
                    DepthOffset = -41
                },
            };
            myBeam.Insert();

            /*
             * Er zijn geen parameters beschikbaar
             */

            return myBeam;
        }
    }
}
