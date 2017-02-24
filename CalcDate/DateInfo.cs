using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalcDate
{
    public class DateInfo
    {
        /// <summary>
        /// 年コンボボックス
        /// </summary>
        private ComboBox _cmbYear;

        /// <summary>
        /// 月コンボボックス
        /// </summary>
        private ComboBox _cmbMonth;

        /// <summary>
        /// 日コンボボックス
        /// </summary>
        private ComboBox _cmbDay;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="cmbYear">年コンボボックス</param>
        /// <param name="cmbMonth">月コンボボックス</param>
        /// <param name="cmbDay">日コンボボックス</param>
        public DateInfo(ComboBox cmbYear, ComboBox cmbMonth, ComboBox cmbDay)
        {
            //-------------------------------------------------------------
            // メンバ設定
            //-------------------------------------------------------------
            _cmbYear = cmbYear;
            _cmbMonth = cmbMonth;
            _cmbDay = cmbDay;

            //-------------------------------------------------------------
            // イベント設定
            //-------------------------------------------------------------
            _cmbYear.SelectedIndexChanged += _cmbYear_SelectedIndexChanged;
            _cmbMonth.SelectedIndexChanged += _cmbMonth_SelectedIndexChanged;

            //-------------------------------------------------------------
            // 年コンボボックス初期化
            //-------------------------------------------------------------
            for (int i = Define.MIN_YEAR; i <= Define.MAX_YEAR; i++)
            {
                _cmbYear.Items.Add(i);
            }
        }

        /// <summary>
        /// 年コンボボックス変更時イベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void _cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-------------------------------------------------------------
            // 日コンボボックス初期化
            //-------------------------------------------------------------
            _cmbMonth.Items.Clear();
            _cmbMonth.SelectedIndex = -1;

            //-------------------------------------------------------------
            // 月コンボボックス初期化
            //-------------------------------------------------------------
            _cmbDay.Items.Clear();
            _cmbDay.SelectedIndex = -1;

            //-------------------------------------------------------------
            // 月コンボボックス設定
            //-------------------------------------------------------------
            for (int iMonth = 1; iMonth <= 12; iMonth++)
            {
                _cmbMonth.Items.Add(iMonth);
            }
        }

        /// <summary>
        /// 月コンボボックス変更時イベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void _cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-------------------------------------------------------------
            // 最終日算出
            //-------------------------------------------------------------
            JapaneseCalendar cal = new JapaneseCalendar();
            int year = (int)_cmbYear.SelectedItem;
            int month = (int)_cmbMonth.SelectedItem;
            int maxDay = cal.GetDaysInMonth(year, month);

            //-------------------------------------------------------------
            // 日コンボボックス初期化
            //-------------------------------------------------------------
            _cmbDay.Items.Clear();
            _cmbDay.SelectedIndex = -1;

            //-------------------------------------------------------------
            // 日コンボボックス設定
            //-------------------------------------------------------------
            for (int iDay = 1; iDay <= maxDay; iDay++)
            {
                _cmbDay.Items.Add(iDay);
            }
        }

        /// <summary>
        /// 今日日付設定
        /// </summary>
        public void SetToday()
        {
            DateTime dtNow = DateTime.Now;
            _cmbYear.SelectedItem = dtNow.Year;
            _cmbMonth.SelectedItem = dtNow.Month;
            _cmbDay.SelectedItem = dtNow.Day;
        }

        /// <summary>
        /// DateTimeオブジェクト取得
        /// </summary>
        public DateTime GetDateTimeObject()
        {
            return new DateTime((int)_cmbYear.SelectedItem, (int)_cmbMonth.SelectedItem, (int)_cmbDay.SelectedItem);
        }

        /// <summary>
        /// 年月日すべてのコンボボックスが選択されているか確認する
        /// </summary>
        public bool IsSelectedYMD()
        {
            if(_cmbYear.SelectedItem == null 
                || _cmbMonth.SelectedItem == null 
                || _cmbDay.SelectedItem == null)
            {
                return false;
            }

            return true;
        }

    }
}
