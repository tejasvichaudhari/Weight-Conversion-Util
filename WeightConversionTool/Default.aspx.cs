using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;



namespace WebApplication3
{
    public partial class _Default : System.Web.UI.Page, IView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setControls();
            }
        }

        protected void setControls()
        {
            ddlSelectUnit.Items.Add("MilliGram");
            ddlSelectUnit.Items.Add("Gram");
            ddlSelectUnit.Items.Add("KiloGram");
            ddlSelectUnit.Items.Add("Ounce");
            ddlSelectUnit.Items.Add("Pound");
            ddlSelectUnit.Items.Add("Stone");

            ddlUnitForConversion.Items.Add("MilliGram");
            ddlUnitForConversion.Items.Add("Gram");
            ddlUnitForConversion.Items.Add("KiloGram");
            ddlUnitForConversion.Items.Add("Ounce");
            ddlUnitForConversion.Items.Add("Pound");
            ddlUnitForConversion.Items.Add("Stone");
        }

        #region IView Members

        public string UnitFrom
        {
            get
            {
                return ddlSelectUnit.SelectedItem.Text;
            }
        }

        public string UnitTo
        {
            get
            {
                return ddlUnitForConversion.SelectedItem.Text;
            }
        }

        public string LabelWord 
        {
            get
            {
                return lblWord.Text;
            }
            set
            {
                lblWord.Text = value;
            }
        }

        public string TextforWordRev
        {
            get
            {
                return txtWord.Text;
            }
            set
            {
                txtWord.Text = value;
            }
        }

        public string TextBoxRevWord
        {
            get
            {
                return txtRevWord.Text;
            }
            set
            {
                txtRevWord.Text = value;
            }
        }

        
        #endregion

        protected void btnGetReverseWord_Click(object sender, EventArgs e)
        {
            Presenter1 p = new Presenter1(this, new WebApplication3.Model());
            p.BindModalView();
        }

       
    }
}
