using System;

namespace IpChallenge
{
    class IpDetails
    {
        private int Segment { get; set; }
        private int SegmentLength { get; set; }

        public void AnalyzeIpAddress(string address)
        {
            Segment = 1;
            SegmentLength = 0;

            if (address == "")
                Segment = 0;

            foreach (var element in address)
            {
                if (element.ToString() != ".")
                {
                    SegmentLength += 1;
                    continue;
                }

                Console.WriteLine($"Segment {Segment} Length: {SegmentLength}");
                SegmentLength = 0;
                Segment += 1;
            }

            Console.WriteLine($"Segment {Segment} Length: {SegmentLength}");
        }
    }
}
