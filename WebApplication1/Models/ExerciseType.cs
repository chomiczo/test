namespace WebApplication1.Models
{
    public class ExerciseType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int ExerciseStatisticsId {  get; set; }
        public ExerciseStatistics Statistics { get; set; }
    }
    public class ExerciseStatistics
    {
        public int Id { get; set; }
        public string ExerciseTypeName { get; set; }
        public int SessionsLastFourWeeks { get; set; }
        public double BestResult { get; set; }
    }
}
