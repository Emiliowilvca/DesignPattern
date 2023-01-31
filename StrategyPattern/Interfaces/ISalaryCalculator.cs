using StrategyPattern.Models;

namespace StrategyPattern.Interfaces
{
    public interface ISalaryCalculator
    {
         double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}