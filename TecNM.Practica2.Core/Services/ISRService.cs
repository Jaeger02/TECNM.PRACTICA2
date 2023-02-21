using TecNM.Practica2.Core.Services.Interfaces;
using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Enums;

namespace TecNM.Practica2.Core.Services;

public class ISRService : IISRService{
    public ISR ProcessISR(Person person){
        var isr = new ISR();
        float baseR;
        float resultado;
        
        if(person.salary <=0.0f)
        {
            isr.Index = 0.00f;
            isr.ISRType = ISRType.NoRange;
        }
        else if (person.salary >=0.01f && person.salary <= 7735.00f)
        {
            baseR = person.salary - 0.01f;
            resultado = baseR * (1.92f/100f);
            isr.Index = resultado + 0.00f;
            isr.ISRType = ISRType.Range1;
        }
        else if (person.salary >=7735.01f && person.salary <= 65651.07f)
        {
            baseR = person.salary - 7735.01f;
            resultado = baseR * (6.40f/100f);
            isr.Index = resultado + 148.51f;
            isr.ISRType = ISRType.Range2;
        }
        else if (person.salary >=65651.08f && person.salary <= 115375.90f)
        {
            baseR = person.salary - 65651.08f;
            resultado = baseR * (10.88f/100f);
            isr.Index = resultado + 3855.14f;
            isr.ISRType = ISRType.Range3;
        }
        else if (person.salary >=115375.91f && person.salary <= 134119.41f)
        {
            baseR = person.salary - 115375.91f;
            resultado = baseR * (16.00f/100f);
            isr.Index = resultado + 9265.20f;
            isr.ISRType = ISRType.Range4;
        }
        else if (person.salary >=134119.42f && person.salary <= 160577.65f)
        {
            baseR = person.salary - 134119.42f;
            resultado = baseR * (17.92f/100f);
            isr.Index = resultado + 12264.16f;
            isr.ISRType = ISRType.Range5;
        }
        else if (person.salary >=160577.66f && person.salary <= 323862.00f)
        {
            baseR = person.salary - 160577.66f;
            resultado = baseR * (21.36f/100f);
            isr.Index = resultado + 17005.47f;
            isr.ISRType = ISRType.Range6;
        }
        else if (person.salary >=323862.01f && person.salary <= 510451.00f)
        {
            baseR = person.salary - 323862.01f;
            resultado = baseR * (23.52f/100f);
            isr.Index = resultado + 51883.01f;
            isr.ISRType = ISRType.Range7;
        }
        else if (person.salary >=510451.01f && person.salary <= 974535.03f)
        {
            baseR = person.salary - 510451.01f;
            resultado = baseR * (30.00f/100f);
            isr.Index = resultado + 95768.74f;
            isr.ISRType = ISRType.Range8;
        }
        else if (person.salary >=974535.04f && person.salary <= 1299380.04f)
        {
            baseR = person.salary - 974535.04f;
            resultado = baseR * (32.00f/100f);
            isr.Index = resultado + 234993.95f;
            isr.ISRType = ISRType.Range9;
        }
        else if (person.salary >=1299380.05f && person.salary <= 3898140.12f)
        {
            baseR = person.salary - 1299380.05f;
            resultado = baseR * (34.00f/100f);
            isr.Index = resultado + 338944.34f;
            isr.ISRType = ISRType.Range10;
        }
        else if (person.salary >=3898140.13f)
        {
            baseR = person.salary - 3898140.13f;
            resultado = baseR * (35.00f/100f);
            isr.Index = resultado + 1222522.76f;
            isr.ISRType = ISRType.Range11;
        }
        return isr;
    }
}