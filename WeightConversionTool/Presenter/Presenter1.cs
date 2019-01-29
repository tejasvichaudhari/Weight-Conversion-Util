using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using WeightConversionTool.file.INI;

namespace WebApplication3
{
    public class Presenter1
    {
        IView _pView;
        IModel _pModel;

        public Presenter1(IView PView, IModel PModel)
        {
            _pView = PView;
            _pModel = PModel;
        }
        public void BindModalView()
        {
            List<String> ls;
            string str = _pView.UnitFrom + "To" + _pView.UnitTo;

            INIFile ini = new INIFile("C:\\Users\\Tejasvi\\Documents\\Visual Studio 2015\\Projects\\WeightConversionTool\\WeightConversionTool\\file\\INI\\weight.ini");
            string key = ini.IniReadValue("Info", str);
            //string value = ini.IniReadValue("Info", "Value");

            ls = _pModel.setInfo(_pView.TextforWordRev, str, key);

            _pView.TextBoxRevWord = ls[0];
            
        }

        //public void BindModalViewForReverseString()
        //{
        //    List<String> ls;
        //    ls = _pModel.setInfo(_pView.TextEnterSentence, "StringCharReverse");
        //    _pView.TextReverseSentence = ls[0];

        //    List<String> ls1;
        //    ls1 = _pModel.setInfo(_pView.TextEnterSentence, "StringReverse");
        //    _pView.TextStringReverse = ls1[0];


        //    List<String> ls2;
        //    ls2 = _pModel.setInfo(_pView.TextEnterSentence, "StringReverseWithRevChar");
        //    _pView.TextStringReverseWithCharRev = ls2[0];
        //}
    }
}