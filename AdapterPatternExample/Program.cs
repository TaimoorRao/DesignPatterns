using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adapter Design Pattern in C#
            Console.WriteLine("Setting input for DVI Monitor");
            VGAGraphicCard vGAGraphicCard = new VGAGraphicCard();
            DVIMonitor dVIMonitor = new DVIMonitor();
            VGAGraphicsCardAdapter vGAGraphicsCardAdapter = new VGAGraphicsCardAdapter(vGAGraphicCard);
            dVIMonitor.setInput(vGAGraphicsCardAdapter.GetDVIStream());
            Console.ReadLine();
        }
    }
    class VGAStream
    {
        private byte[] _stream;
        public void setData(byte[] stream)
        {
            _stream = stream;
        }
        public byte[] getData()
        {
            return _stream;
        }
    }
    class VGAGraphicCard
    {
        public VGAStream getVGAStream()
        {
            VGAStream vgaStream = new VGAStream();
            vgaStream.setData(new byte[] { });
            return vgaStream;
        }
    }
    class DVIStream
    {
        private byte[] _stream;
        public void setData(byte[] stream)
        {
            _stream = stream;
        }
        public byte[] getData()
        {
            return _stream;
        }
    }
    class DVIMonitor
    {
        private byte[] _inputStream;
        public void setInput(DVIStream dVIStream)
        {
            _inputStream = dVIStream.getData();
        }
    }
    class VGAGraphicsCardAdapter
    {
        private VGAGraphicCard _vGAGraphicCard;
        public VGAGraphicsCardAdapter(VGAGraphicCard vGAGraphicCard)
        {
            _vGAGraphicCard = vGAGraphicCard;
        }
        public DVIStream GetDVIStream()
        {
            byte[] data = _vGAGraphicCard.getVGAStream().getData();

            // process and convert the vga into dvi video stream
            byte[] dviVideoData = ConvertFromVGAToDVI(data);
            DVIStream dVIStream = new DVIStream();
            dVIStream.setData(dviVideoData);
            return dVIStream;
        }
        private byte[] ConvertFromVGAToDVI(byte[] input)
        {
            Console.WriteLine("Converted VGA video to DVI video");
            return new byte[] { };
        }
    }
}