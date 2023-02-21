using TecNM.Practica2.Core.Entities;

namespace TecNM.Practica2.Core.Services.Interfaces;

public interface IISRService{
    ISR ProcessISR(Person person);
}