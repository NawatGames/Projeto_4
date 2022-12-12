using System.Collections.Generic;
using ElementSystem;

public class ElementGenerator {
    private SecundaryElementSO[] _secundaryElementsContainer;
    public Dictionary<PrimeElementSO[], SecundaryElementSO> ElementsDict = new();

    public ElementGenerator(SecundaryElementSO[] secundaryElementSos) {
        _secundaryElementsContainer = secundaryElementSos;

        foreach (var elementSo in _secundaryElementsContainer) {
            ElementsDict.Add(elementSo._primeElementsComposerArray, elementSo);
        }
    }
}