using System.Globalization;

namespace DateCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxTime1.Text = DateTime.Now.ToString("HH:mm:ss");
            labelLog.Text = string.Empty;
            labelComment.Text = string.Empty;
        }

        private void buttonDiff_Click(object sender, EventArgs e)
        {
            var date1 = dateTimePicker1.Value;
            var date2 = dateTimePicker2.Value;

            if (date1 > date2)
            {
                var result1 = date1.Subtract(date2);
                var result = CalculateDiff(date1, date2);

                labelResult.Text = $"{result.Years} év, {result.Months} hónap, {result.Days} nap\n{result1.Days} nap összesen";
                labelLog.Text += $"{date1.ToString("yyyy.MM.dd.")} - {date2.ToString("yyyy.MM.dd.")} = {result.Years} év, {result.Months} hónap, {result.Days} nap (összesen: {result1.Days} nap)\n";
            }
            else
            {
                var result1 = date2.Subtract(date1);
                var result = CalculateDiff(date1, date2);
                labelResult.Text = $"{result.Years} év, {result.Months} hónap, {result.Days} nap\n{result1.Days} nap összesen";
                labelLog.Text += $"{date2.ToString("yyyy.MM.dd.")} - {date1.ToString("yyyy.MM.dd.")} = {result.Years} év, {result.Months} hónap, {result.Days} nap (összesen: {result1.Days} nap)\n";
            }
        }

        private void buttonTimeDiff_Click(object sender, EventArgs e)
        {
            textBoxTime1.Text = FormatTime(textBoxTime1.Text);
            textBoxTime2.Text = FormatTime(textBoxTime2.Text);

            if (string.IsNullOrWhiteSpace(textBoxTime1.Text) || string.IsNullOrWhiteSpace(textBoxTime2.Text))
            {
                labelResult.Text = "Hiba, üres mezõ!";
                return;
            }
            if (!TimeSpan.TryParseExact(textBoxTime1.Text, new string[] { @"hh\:mm\:ss", @"hh\:mm" }, CultureInfo.InvariantCulture, out var time) ||
                !TimeSpan.TryParseExact(textBoxTime2.Text, new string[] { @"hh\:mm\:ss", @"hh\:mm" }, CultureInfo.InvariantCulture, out time))
            {
                labelResult.Text = "Hiba, helytelen formátum!";
                return;
            }

            TimeSpan t1 = TimeSpan.Parse(textBoxTime1.Text, CultureInfo.InvariantCulture);
            TimeSpan t2 = TimeSpan.Parse(textBoxTime2.Text, CultureInfo.InvariantCulture);
            if (t1 < t2)
            {
                labelComment.Text = string.Empty;
            }
            else
            {
                labelComment.Text = "Napon átívelõ!";
            }
            //var result = t2 - t1;
            //labelResult.Text = $"{result.Hours} óra, {result.Minutes} perc, {result.Seconds} másodperc\n{result.TotalSeconds} másodperc összesen";
            //labelLog.Text += $"{t2} - {t1} = {result.Hours} óra, {result.Minutes} perc, {result.Seconds} másodperc ({result.TotalSeconds} másodperc összesen)\n";

            var result = t1 - t2;
            labelResult.Text = $"{result.Hours} óra, {result.Minutes} perc, {result.Seconds} másodperc\n{result.TotalSeconds} másodperc összesen";
            labelLog.Text += $"{t1} - {t2} = {result.Hours} óra, {result.Minutes} perc, {result.Seconds} másodperc ({result.TotalSeconds} másodperc összesen)\n";

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            var date1 = dateTimePickerAddSub.Value;
            var year = numericUpDownYear.Value;
            var month = numericUpDownMonth.Value;
            var days = numericUpDownDay.Value;

            var result = date1.AddYears((int)year);
            result = result.AddMonths((int)month);
            result = result.AddDays((double)days);
            labelResult.Text = result.ToString("yyyy.MM.dd.");
            labelLog.Text += $"{date1.ToString("yyyy.MM.dd.")} + {year} év + {month} hó + {days} nap = {result.ToString("yyyy.MM.dd.")}\n";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            var date1 = dateTimePickerAddSub.Value;
            var year = numericUpDownYear.Value;
            var month = numericUpDownMonth.Value;
            var days = numericUpDownDay.Value;

            var result = date1.AddYears(-(int)year);
            result = result.AddMonths(-(int)month);
            result = result.AddDays((double)days);
            labelResult.Text = result.ToString("yyyy.MM.dd.");
            labelLog.Text += $"{date1.ToString("yyyy.MM.dd.")} - {year} év - {month} hó - {days} nap = {result.ToString("yyyy.MM.dd.")}\n";
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private CountOfDate CalculateDiff(DateTime startDate, DateTime endDate)
        {
            var counts = new CountOfDate();
            for (var i = 1; ; ++i)
            {
                if (startDate.AddYears(i) > endDate)
                {
                    counts.Years = i - 1;

                    break;
                }
            }

            for (var i = 1; ; ++i)
            {
                if (startDate.AddYears(counts.Years).AddMonths(i) > endDate)
                {
                    counts.Months = i - 1;

                    break;
                }
            }

            for (var i = 1; ; ++i)
            {
                if (startDate.AddYears(counts.Years).AddMonths(counts.Months).AddDays(i) > endDate)
                {
                    counts.Days = i - 1;

                    break;
                }
            }
            return counts;
        }

        private void numericUpDownDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTime1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            var temp = textBoxTime2.Text;
            textBoxTime2.Text = textBoxTime1.Text;
            textBoxTime1.Text = temp;
        }

        private void textBoxTime1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBoxTime2_Leave(object sender, EventArgs e)
        {

            textBoxTime2.Text = FormatTime(textBoxTime2.Text);
        }

        private string FormatTime(string time)
        {
            if (time.Length > 2)
            {
                time = time.Replace(":", "");
            }            
            if (time.Length == 4 && !time.Contains(":"))
            {
                time = time.Insert(2, ":");
            }
            if (time.Length > 5 && time.Count(x => x == ':') < 2)
            {
                time = time.Insert(2, ":").Insert(5, ":");
            }
            return time;
        }

        private void textBoxTime1_Leave(object sender, EventArgs e)
        {
            textBoxTime1.Text = FormatTime(textBoxTime1.Text);
        }
    }
}
