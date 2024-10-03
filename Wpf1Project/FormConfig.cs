using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf1Project
{
    static class FormConfig
    {
        public static Window FrmSolid {  get; set; }=new SolidWindow();
        public static Window FrmLinearGradient { get; set; }=new LinearGradient();

        public static Window FrmRadialGradient { get;set; }=new RadialGradient();
        public static Window FrmImage { get;set; }=new ImageWindow();

        public static Window FrmVisual { get; set; }=new VisualBrushWindow();

        public static Window FrmEditor { get; set; } = new EditorWindow();


        public static Window FrmStack { get; set; } = new StackWindow();
        public static Window FrmWrap { get; set; } = new WrapWindow();
        public static Window FrmCanvas { get; set; } =new CanvasWindow();

        public static Window FrmDock { get;set; }=new DockWindow();
        public static Window FrmGrid { get;set;}=new GridWindow();
    }
}
