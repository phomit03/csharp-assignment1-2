using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T2108M_UMP.Module;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2108M_UMP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            List<Student> list = new List<Student>();
            StudentList.Items.Add(new Student() 
            {
                Id=1,
                Name= "Khổng Thị Thương",
                Age=20,
                Address= "8 Tôn Thất Thuyết"
            });
            StudentList.Items.Add(new Student()
            {
                Id = 2,
                Name = "Nguyễn Xuân Thảo",
                Age = 18,
                Address = "8 Tôn Thất Thuyết"
            });
        }
    }
}
