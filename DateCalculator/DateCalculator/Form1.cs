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
            if (!TimeSpan.TryParseExact(textBoxTime1.Text, new string[] { @"hh\:mm\:ss", @"hh\:mm", @"h\:m" }, CultureInfo.InvariantCulture, out var time) ||
                !TimeSpan.TryParseExact(textBoxTime2.Text, new string[] { @"hh\:mm\:ss", @"hh\:mm", @"h\:m" }, CultureInfo.InvariantCulture, out time))
            {
                labelResult.Text = "Hiba, helytelen formátum!";
                return;
            }

            TimeSpan t1 = TimeSpan.Parse(textBoxTime1.Text, CultureInfo.InvariantCulture);
            TimeSpan t2 = TimeSpan.Parse(textBoxTime2.Text, CultureInfo.InvariantCulture);
            var result = t2 - t1;
            if (result.TotalMicroseconds < 0)
            {
                var aDay = new TimeSpan(1, 0, 0, 0);
                result = aDay + result;
                labelComment.Text = "Napon átívelõ!";
                labelResult.Text = $"{result.Hours} óra, {result.Minutes} perc, {result.Seconds} másodperc\n{result.TotalSeconds} másodperc összesen";
                labelLog.Text += $"{t2} - {t1} = {result.Hours} óra, {result.Minutes} perc, {result.Seconds} másodperc ({result.TotalSeconds} másodperc összesen)\n";
            }
            else
            {
                labelComment.Text = string.Empty;
                labelResult.Text = $"{result.Hours} óra, {result.Minutes} perc, {result.Seconds} másodperc\n{result.TotalSeconds} másodperc összesen";
                labelLog.Text += $"{t2} + {t1} = {result.Hours} óra, {result.Minutes} perc, {result.Seconds} másodperc ({result.TotalSeconds} másodperc összesen)\n";

            }


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

        private string FormatTime(string rawTime)
        {
            if (rawTime.Contains(":"))
            {
                return rawTime;
            }
            rawTime = rawTime.PadLeft(4, '0');

            int length = rawTime.Length;

            if (length <= 2)
            {
                return $"0:{rawTime.PadLeft(2, '0')}";
            }
            else if (length <= 4)
            {
                string minutes = rawTime.Substring(0, length - 2);
                string seconds = rawTime.Substring(length - 2);
                return $"{minutes}:{seconds}";
            }
            else
            {
                string hours = rawTime.Substring(0, length - 4);
                string minutes = rawTime.Substring(length - 4, 2);
                string seconds = rawTime.Substring(length - 2);
                return $"{hours}:{minutes}:{seconds}";
            }
        }

        private void textBoxTime1_Leave(object sender, EventArgs e)
        {
            textBoxTime1.Text = FormatTime(textBoxTime1.Text);
        }

        private void buttonTimePicker1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonTimePicker2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
