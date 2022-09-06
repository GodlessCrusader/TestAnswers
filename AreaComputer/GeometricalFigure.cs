using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaComputer
{
    
    public class GeometricalFigure
    {
        protected GeometricalFigure()
        {

        }
        public GeometricalFigure(List<Chunk> chunks)
        {
            this.chunks = chunks;
            ComputeArea();
        }
         
        protected void ComputeArea()
        {
            Area = 0;
            foreach(Chunk chunk in chunks)
            {
                Area = chunk.Area + Area;
            }
        }
        
            
        protected List<Chunk> chunks = new List<Chunk>();
        public double Area {private set;  get;}
        
    }
}
