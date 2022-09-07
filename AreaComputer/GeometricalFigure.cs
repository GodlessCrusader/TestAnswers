using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaComputer
{
    
    public class GeometricalFigure
    {
        
        public GeometricalFigure(IEnumerable<Chunk> chunks)
        {
            this.chunks = chunks;
            ComputeAreaWithChunks();
        }

        public GeometricalFigure(Func<IList<double>, double> areaFormule, IList<double> arguments)
        {
            this.AreaComputeFormule = areaFormule;
            this.areaArgs = arguments;
            ComputeAreaWithFormule();
        }

        public void ComputeAreaWithChunks()
        {
            Area = 0;
            foreach(Chunk chunk in chunks)
            {
                Area = chunk.Area + Area;
            }
        }
        public void ComputeAreaWithFormule()
        {
            Area = AreaComputeFormule(areaArgs);
        }
        public Func<IList<double>, double>? AreaComputeFormule;
        public IList<double>? areaArgs;
        public IEnumerable<Chunk>? chunks;
        public double Area {private set;  get;}
        
    }
}
