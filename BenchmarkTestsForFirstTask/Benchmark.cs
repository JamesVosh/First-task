using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using First_task;
namespace Benchmark
{
    class Program
    {
        static void Main()
        {
            var summary = BenchmarkRunner.Run<FirstTaskBenchmark>();
        }
    }
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class FirstTaskBenchmark
    {
        private Mat_tochki.Voditeli vodit_bench = new Mat_tochki.Voditeli();
        [GlobalSetup]
        public void Setup()
        {
            Mat_tochki.Zakazi zakaz_bench = new Mat_tochki.Zakazi(5, 7);
            int i = 0;
            vodit_bench.N = 20; vodit_bench.M = 20;
            vodit_bench.Append(vodit_bench, new Mat_tochki(0, 0, "v1"));
            vodit_bench.Append(vodit_bench, new Mat_tochki(3, 1, "v2"));
            vodit_bench.Append(vodit_bench, new Mat_tochki(2, 7, "v3"));
            vodit_bench.Append(vodit_bench, new Mat_tochki(5, 3, "v4"));
            vodit_bench.Append(vodit_bench, new Mat_tochki(11, 7, "v5"));
            vodit_bench.Append(vodit_bench, new Mat_tochki(10, 1, "v6"));
            vodit_bench.Append(vodit_bench, new Mat_tochki(9, 5, "v7"));
            vodit_bench.Append(vodit_bench, new Mat_tochki(7, 10, "v8"));
            vodit_bench.Append(vodit_bench, new Mat_tochki(4, 7, "v9"));
            vodit_bench.Append(vodit_bench, new Mat_tochki(4, 6, "v10"));
            while (i < vodit_bench.Len(vodit_bench))
            {
                vodit_bench[i].X = vodit_bench[i].X - zakaz_bench.X;
                vodit_bench[i].Y = vodit_bench[i].Y - zakaz_bench.Y;
                i++;
            }
        }
        [Benchmark]
        public void Sort_Shella_10()
        {
            vodit_bench.Sort_Shella(vodit_bench, vodit_bench.Len(vodit_bench));
        }
        [Benchmark]
        public void Sort_bubble_10()
        {
            vodit_bench.Sort_bubble(vodit_bench, vodit_bench.Len(vodit_bench));
        }
        [Benchmark]
        public void Sort_direct_choice_10()
        {
            vodit_bench.Sort_direct_choice(vodit_bench, vodit_bench.Len(vodit_bench));
        }
    }
}