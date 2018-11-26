using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmGuide : Form
    {
        public FrmGuide()
        {
            InitializeComponent();
            textBox1.Text = "Đây là phần mềm thay thế cho bàn điều khiển quầy của hệ thống QMS.\r\nĐể Phần mềm Điều khiển gọi số hoạt động được trong hệ thống QMS, cần có:\r\n"
                + "- Chương trình quản lý chung QMS version 5.0 trở lên phải được cài đặt và hoạt động bình thường.\r\n"
   + "- Phần mềm Điều khiển gọi số phải kết nối thành công đến cơ sở dữ liệu của hệ thống QMS.\r\n"
   + "- Cài đặt giữa chương trình chính QMS và Counter Soft cũng phải tương thích nhau.\r\n"
 + "Các tính năng cụ thể của phần mềm và cách sử dụng đều được hướng dẫn trực quan tại chỗ mỗi khi người dùng đưa chuột vào các nút chức năng tương ứng trên giao diện phần mềm.\r\n"
 + "Trong quá trình sử dụng, nếu gặp khó khăn, Quý khách vui lòng liên lạc trực tiếp với nhân viên phụ trách hệ thống để được giúp đỡ.\r\n"
 + "Trân trọng cảm ơn Quý khách đã tin dùng sản phẩm của chúng tôi!\r\n"
+ "Công ty TNHH Công Nghệ Chuyên Nghiệp Phát Triển";
            //+ "Website: www.haidang.vn";
        }
    }
}
