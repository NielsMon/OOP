using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public static class MeetkundigeFormules
    {
        // methoden
        public static double OppervlakteRechthoek(double lengte, double breedte)
        {
            return lengte * breedte;
        }
        public static double OppervlakteCirkel(double straal)
        {
            return Math.PI * (straal*straal);
        }
        public static double VolumeBalk(double lengte, double breedte, double hoogte)
        {
            return lengte * breedte * hoogte;
        }
        public static double VolumeCilinder(double straal, double hoogte)
        {
            return Math.PI * (straal * straal) * hoogte;
        }
    }
}
