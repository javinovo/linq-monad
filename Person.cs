
class Person
{
    public string Name { get; set; }
    public Person ReportsTo { get; set; }
}

class MonadicPerson
{
    public string Name { get; set; }
    public Maybe<MonadicPerson> ReportsTo { get; set; }
}

static class GetSupervisorNameExtensions
{
    public static string GetSupervisorName(this Person employee) =>
        employee?.ReportsTo?.ReportsTo?.Name;

    public static Maybe<string> GetSupervisorName(this Maybe<MonadicPerson> maybeEmployee) =>
        from employee in maybeEmployee
        from supervisor in employee.ReportsTo
        from supervisorSupervisor in supervisor.ReportsTo
        select supervisorSupervisor.Name;
}