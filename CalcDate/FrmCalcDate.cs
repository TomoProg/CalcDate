using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcDate
{
    public partial class FrmCalcDate : Form
    {
        /// <summary>
        /// 開始日情報
        /// </summary>
        DateInfo _startDateInfo;

        /// <summary>
        /// 終了日情報
        /// </summary>
        DateInfo _endDateInfo;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FrmCalcDate()
        {
            InitializeComponent();
            _startDateInfo = new DateInfo(cmbStartYear, cmbStartMonth, cmbStartDay);
            _endDateInfo = new DateInfo(cmbEndYear, cmbEndMonth, cmbEndDay);
        }

        /// <summary>
        /// フォームロード
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void FrmCalcDate_Load(object sender, EventArgs e)
        {
            //-------------------------------------------------------------
            // 本日日付設定
            //-------------------------------------------------------------
            _startDateInfo.SetToday();
            _endDateInfo.SetToday();
        }

        /// <summary>
        /// 計算ボタンクリックイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //-------------------------------------------------------------
            // 出力項目クリア
            //-------------------------------------------------------------
            SetMsg();
            SetResult();

            //-------------------------------------------------------------
            // 開始日チェック
            //-------------------------------------------------------------
            if (!_startDateInfo.IsSelectedYMD())
            {
                SetMsg("開始日を指定してください。");
                return;
            }

            //-------------------------------------------------------------
            // 終了日チェック
            //-------------------------------------------------------------
            if (!_endDateInfo.IsSelectedYMD())
            {
                SetMsg("終了日を指定してください。");
                return;
            }

            //-------------------------------------------------------------
            // 差分計算
            //-------------------------------------------------------------
            DateTime dtStart = _startDateInfo.GetDateTimeObject();
            DateTime dtEnd = _endDateInfo.GetDateTimeObject();
            TimeSpan ts = dtEnd - dtStart;
            if(ts.Days < 0)
            {
                SetMsg("開始日が終了日を超えています。");
                return;
            }

            //-------------------------------------------------------------
            // 結果表示
            //-------------------------------------------------------------
            SetResult(ts.Days.ToString());
        }

        /// <summary>
        /// メッセージ設定
        /// </summary>
        private void SetMsg(string msg = "")
        {
            lblMsg.Text = msg;
        }

        /// <summary>
        /// 結果設定
        /// </summary>
        private void SetResult(string diffDay = "")
        {
            lblResult.Text = diffDay;
        }
    }
}
