using System.Collections.Generic;
using System.Linq;
using ElementSystem;
using Main_Scripts.ElementSystem;

public class ElementGenerator {
    private SecondaryElementSO[] _secondaryElementsContainer;
    public readonly Dictionary<string, SecondaryElementSO> ElementsDict = new();

    public ElementGenerator(ref SecondaryElementSO[] secondaryElementSos) {
        _secondaryElementsContainer = secondaryElementSos;

        foreach (var elementSo in _secondaryElementsContainer) {
            var primeElementsArrayOrdered = elementSo._primeElementsComposerArray.OrderBy(x => x.name);

            string hash = "";
            foreach (var primeElement in primeElementsArrayOrdered) {
                hash += primeElement.GetHashCode();
            }
            
            ElementsDict.Add(hash, elementSo);
        }
    }

    public SecondaryElementSO GetValueFromKey(ElementSO[] primeElementsArray) {
        var primeElementsArrayOrdered = primeElementsArray.OrderBy(x => x.name);
        var hash = "";
        foreach (var primeElement in primeElementsArrayOrdered) {
            hash += primeElement.GetHashCode();
        }

        return ElementsDict.TryGetValue(hash, out var elementToReturn) ? elementToReturn : null;
    }
    
}