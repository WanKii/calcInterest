class Program
{
    /// <summary>
    /// 复利计算利息
    /// </summary>
    static void Main()
    {
        double initMoney = 60000;//本金
        double rate = 0.028;//年利率
        int month = 12 * 1;//月份（多年的话乘年份即可）
        double add = 5000;//加投

        (double total, double totalAdd) = Calc(initMoney, rate, month, add);
        Console.WriteLine($"\n年利率：{rate}");
        Console.WriteLine($"初始本金：{initMoney}，每月加投：{add}");
        Console.WriteLine($"复利投资 {month}个月");
        Console.WriteLine($"最终本金：{total}");
        Console.WriteLine($"总投资本金：{totalAdd}");
        Console.WriteLine($"总收益：{Math.Round(total - totalAdd)}");
    }

    static (double, double) Calc(double initMoney, double rate, int month, double add)
    {
        double total = initMoney;
        double totalAdd = initMoney;

        for (int i = 1; i <= month; i++)
        {
            var interest = Math.Round(total * rate / 365 * 30);//当月利息
            Console.WriteLine($"第{i}月 本金：{Math.Round(total)} 月利息：{interest}");
            total = interest + total;//当月本金
            total += add;//当月本金加投
            totalAdd += add;//统计总投资本金
        }

        return (Math.Round(total), Math.Round(totalAdd));
    }
}