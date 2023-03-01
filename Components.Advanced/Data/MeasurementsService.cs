namespace Components.Advanced.Data
{
    public class MeasurementsService
    {
        public ValueTask<List<Measurement>> GetMeasurements()
        {
            const int nrOfRows = 5000;
            var result = new List<Measurement>();
            var rnd = new Random();
            for (int i = 0; i < nrOfRows; i += 1)
            {
                result.Add(new Measurement()
                {
                    Guid = Guid.NewGuid(),
                    Min = rnd.Next(0, 100),
                    Avg = rnd.Next(100, 300),
                    Max = rnd.Next(300, 400),
                });
            }
            return new ValueTask<List<Measurement>>(result);
        }



        public ValueTask<(List<Measurement>, int)> GetMeasurementsPage(int from, int count, CancellationToken cancellationToken)
        {
            const int maxMeasurements = 5000;
            var result = new List<Measurement>();
            var rnd = new Random();
            count = Math.Max(0, Math.Min(count, maxMeasurements - from));
            for (int i = 0; i < count; i += 1)
            {
                result.Add(new Measurement()
                {
                    Guid = Guid.NewGuid(),
                    Min = rnd.Next(0, 100),
                    Avg = rnd.Next(100, 300),
                    Max = rnd.Next(300, 400),
                });
            }
            return new ValueTask<(List<Measurement>, int)>((result, maxMeasurements));
        }


    }
}
