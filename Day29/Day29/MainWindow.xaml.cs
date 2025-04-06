using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Day29;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<Student> students;
    public MainWindow()
    {
        InitializeComponent();
    }
    public class Student//Generic collectionukaga publica oru property variable declare panrom.
    {
        public int sno { get; set; }//get-> is only read for the user||set-> it is used to assign a value for a user
        public string sname { get; set; }
        public string scourse{ get; set; } 
    }
    private void btnregister_Click(object sender, RoutedEventArgs e)
    {
        if(students is null)
        {
            students = new List<Student>();//list create panrom.

        }
        Student stud = new Student();//Generic class object  vachi oru tiem create panrom.
        stud.sno = Convert.ToInt16(txtsno.Text);
        stud.sname = txtsname.Text;
        stud.scourse = txtsscourse.Text;
        students.Add(stud);//Generic class objecta vachi create pana itema eduthu list la add panrom.

        //list itemsa eduthu List view la bind panra process.
        lstview.ItemsSource = null;
        lstview.ItemsSource = students;

        //Create pana items elathaum list box la show pana porom.
        lstbox.ItemsSource= null;
        lstbox.DisplayMemberPath = "sname";
        lstbox.ItemsSource = students;//create pana list elathaum listbox.Itemsource  la add panrom
    }
}