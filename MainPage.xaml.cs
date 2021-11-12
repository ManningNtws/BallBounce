using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace testSkia2
{
    public partial class MainPage : ContentPage
    {
        float xcord1, ycord1, radius1, vx1, vy1, xcord2, ycord2, radius2, vx2, vy2, xcord3, ycord3, radius3, vx3, vy3;

        public MainPage()
        {
            InitializeComponent();

            xcord1 = 200;
            ycord1 = 200;
            radius1 = 50;
            vx1 = 10f; vy1 = -4f;

            xcord2 = 300;
            ycord2 = 100;
            radius2 = 45;
            vx2 = 3f; vy2 = -4f;

            xcord3 = 400;
            ycord3 = 150;
            radius3 = 34;
            vx3 = -5f; vy3 = 5.6f;

            Device.StartTimer(TimeSpan.FromMilliseconds(50), () =>
            {
                canvasView.InvalidateSurface();
                return true;

            });
        }

        private void canvasView_PaintSurface(System.Object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear(SKColors.Aquamarine);
            SKSize size = canvasView.CanvasSize;

            SKPaint Ball1 = new SKPaint();
            Ball1.Color = SKColors.MediumPurple;
            canvas.DrawCircle(xcord1, ycord1, radius1, Ball1);

            xcord1 += vx1;
            ycord1 += vy1;

            SKPaint Ball2 = new SKPaint();
            Ball2.Color = SKColors.Coral;
            canvas.DrawCircle(xcord2, ycord2, radius2, Ball2);

            xcord2 += vx2;
            ycord2 += vy2;

            SKPaint Ball3 = new SKPaint();
            Ball3.Color = SKColors.DarkViolet;
            canvas.DrawCircle(xcord3, ycord3, radius3, Ball3);

            xcord3 += vx3;
            ycord3 += vy3;

            if ((xcord1 > size.Width - radius1) || (xcord1 < radius1)) vx1 = -vx1;
            if ((ycord1 > size.Height - radius1) || (ycord1 < radius1)) vy1 = -vy1;

            if ((xcord2 > size.Width - radius2) || (xcord1 < radius2)) vx2 = -vx2;
            if ((ycord2 > size.Height - radius2) || (ycord2 < radius2)) vy2 = -vy2;

            if ((xcord3 > size.Width - radius3) || (xcord3 < radius3)) vx3 = -vx3;
            if ((ycord3 > size.Height - radius3) || (ycord3 < radius3)) vy3 = -vy3;


        }
    }
}
