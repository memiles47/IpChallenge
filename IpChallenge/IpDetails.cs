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
            {
                address = ".";
                Segment = 0;
            }

            foreach (var element in address)
            {
                if (element.ToString() != ".")
                {
                    SegmentLength += 1;
                    continue;
                }

                Message();
                SegmentLength = 0;
                Segment += 1;
            }

            if (address[address.Length - 1].ToString() != ".")
                Message();
        }

        private void Message()
        {
            Console.WriteLine($"Segment {Segment} Length: {SegmentLength}");
        }
    }
}
