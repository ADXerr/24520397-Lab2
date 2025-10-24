using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Lab2
{
    public partial class bai3 : Form
    {
        private const string InputFileName = "input3.txt";
        private const string OutputFileName = "output3.txt";
        public bai3()
        {
            InitializeComponent();
        }

        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(InputFileName))
                {
                    MessageBox.Show($"Không tìm thấy file '{InputFileName}'. Vui lòng tạo file và thử lại.", "Lỗi File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(InputFileName);
                this.readInput.Text = string.Join(Environment.NewLine, lines);
                List<string> outputLines = new List<string>();

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();

                    if (string.IsNullOrWhiteSpace(trimmedLine))
                    {
                        outputLines.Add(string.Empty);
                        continue;
                    }

                    string resultText;

                    try
                    {
                        double result = Calculate(trimmedLine);
                        resultText = $"{trimmedLine} = {result}";
                    }
                    catch (DivideByZeroException)
                    {
                        resultText = $"{trimmedLine} = LỖI: Chia cho 0";
                    }
                    catch (InvalidOperationException ex)
                    {
                        resultText = $"{trimmedLine} = LỖI CÚ PHÁP: {ex.Message}";
                    }
                    catch (Exception ex)
                    {
                        resultText = $"{trimmedLine} = LỖI: {ex.Message}";
                    }

                    outputLines.Add(resultText);
                }

                File.WriteAllLines(OutputFileName, outputLines);
                this.readOutput.Text = string.Join(Environment.NewLine, outputLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống hoặc I/O khi xử lý file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int Precedence(string op)
        {
            if (op == "+" || op == "-") return 1;
            if (op == "*" || op == "/") return 2;
            return 0;
        }

        private static double PerformOperation(double op1, double op2, string op)
        {
            switch (op)
            {
                case "+": return op1 + op2;
                case "-": return op1 - op2;
                case "*": return op1 * op2;
                case "/":
                    if (op2 == 0) throw new DivideByZeroException("Lỗi: Chia cho 0.");
                    return op1 / op2;
                default: throw new ArgumentException("Toán tử không hợp lệ.");
            }
        }

        private double Calculate(string expression)
        {
            string pattern = @"(\d+\.\d+|\d+|\.\d+|[+\-*/()])";
            var tokens = new List<string>();
            foreach (Match m in Regex.Matches(expression.Replace(" ", ""), pattern))
            {
                tokens.Add(m.Value);
            }

            Stack<double> values = new Stack<double>();
            Stack<string> ops = new Stack<string>();

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    values.Push(number);
                }
                else if (token == "(")
                {
                    ops.Push(token);
                }
                else if (token == ")")
                {
                    while (ops.Count > 0 && ops.Peek() != "(")
                    {
                        string op = ops.Pop();
                        double op2 = values.Pop();
                        double op1 = values.Pop();
                        values.Push(PerformOperation(op1, op2, op));
                    }
                    if (ops.Count == 0 || ops.Peek() != "(")
                        throw new InvalidOperationException("Biểu thức sai: Thiếu ngoặc mở.");
                    ops.Pop();
                }
                else
                {
                    while (ops.Count > 0 && Precedence(ops.Peek()) >= Precedence(token))
                    {
                        string op = ops.Pop();
                        double op2 = values.Pop();
                        double op1 = values.Pop();
                        values.Push(PerformOperation(op1, op2, op));
                    }
                    ops.Push(token);
                }
            }

            while (ops.Count > 0)
            {
                if (ops.Peek() == "(")
                    throw new InvalidOperationException("Biểu thức sai: Thiếu ngoặc đóng.");

                string op = ops.Pop();
                double op2 = values.Pop();
                double op1 = values.Pop();
                values.Push(PerformOperation(op1, op2, op));
            }

            return values.Pop();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
