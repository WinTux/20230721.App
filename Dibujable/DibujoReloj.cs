using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230721.Dibujable
{
    public class DibujoReloj : IDrawable
    {
        public DibujoReloj()
        {
            
        }
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            DateTime tiempoActual = DateTime.Now;
            PointF centroReloj = new PointF(200, 300);
            var radioCirculo = 100;

            canvas.StrokeColor = Colors.Purple;
            canvas.StrokeSize = 6;

            canvas.DrawCircle(centroReloj, radioCirculo);
            canvas.DrawCircle(centroReloj, 5);

            canvas.StrokeSize = 4;
            PointF horero = GetManecillaHora(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, horero);

            PointF minutero = GetManecillaMinuto(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, minutero);

            PointF segundero = GetManecillaSegundo(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, segundero);
        }

        private PointF GetManecillaHora(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int horaActual = tiempoActual.Hour;
            if (horaActual > 12) horaActual -= 12;
            var anguloGrad = horaActual * 360 / 12;
            var anguloRad = Math.PI / 180.0 * anguloGrad;
            var longitudHorero = radioCirculo * 0.8;
            PointF extremoManecilla = new PointF((float)(longitudHorero * Math.Sin(anguloRad)) + centroReloj.X, (float)(-longitudHorero * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremoManecilla;
        }
        private PointF GetManecillaMinuto(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int minutoActual = tiempoActual.Minute;
            var anguloGrad = minutoActual * 360 / 60;
            var anguloRad = Math.PI / 180.0 * anguloGrad;
            PointF extremoManecilla = new PointF((float)(radioCirculo * Math.Sin(anguloRad)) + centroReloj.X, (float)(-radioCirculo * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremoManecilla;
        }
        private PointF GetManecillaSegundo(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int segundoActual = tiempoActual.Second;
            var anguloGrad = segundoActual * 360 / 60;
            var anguloRad = Math.PI / 180.0 * anguloGrad;
            PointF extremoManecilla = new PointF((float)(radioCirculo * Math.Sin(anguloRad)) + centroReloj.X, (float)(-radioCirculo * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremoManecilla;
        }
    }
}
