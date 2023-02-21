using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Managers.Interfaces;
using TecNM.Practica2.Core.Services.Interfaces;

namespace TecNM.Practica2.Core.Managers;

public class ISRManager : IISRManager{
    private readonly IISRService _service;
    public ISRManager(IISRService service){
        _service = service;
    }

    public ISR GetISR(Person person){
        return _service.ProcessISR(person);
    }
}