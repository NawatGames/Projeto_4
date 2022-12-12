using ElementSystem;
using NUnit.Framework;
using UnityEngine;

public class ElementGenerator_Should {
    private ElementGenerator _generator;
    private PrimeElementSO[] _mockPrimeList1;
    private PrimeElementSO[] _mockPrimeList2;
    private SecundaryElementSO[] _mockSecundaryList;

    [SetUp]
    public void SetupAllTests() {
        PrimeElementSO[] mockPrimeContainer =
            { ScriptableObject.CreateInstance<PrimeElementSO>(), ScriptableObject.CreateInstance<PrimeElementSO>(), ScriptableObject.CreateInstance<PrimeElementSO>(), ScriptableObject.CreateInstance<PrimeElementSO>() };

        _mockPrimeList1 = new[] { mockPrimeContainer[0], mockPrimeContainer[1] };
        _mockPrimeList2 = new[] { mockPrimeContainer[2], mockPrimeContainer[3] };
        
        _mockSecundaryList = new[] { ScriptableObject.CreateInstance<SecundaryElementSO>(), ScriptableObject.CreateInstance<SecundaryElementSO>()};
        _mockSecundaryList[0]._primeElementsComposerArray = _mockPrimeList1;
        _mockSecundaryList[1]._primeElementsComposerArray = _mockPrimeList2;
        _generator = new ElementGenerator(_mockSecundaryList);
    }
    
    [Test]
    public void Return_Element_At_Index_1() {
        var elementReturned = _generator.ElementsDict[_mockPrimeList2];
        
        Assert.AreSame(_mockSecundaryList[1], elementReturned);
    }
    
    [Test]
    public void Return_Element_At_Index_0() {
        var elementReturned = _generator.ElementsDict[_mockPrimeList1];
        
        Assert.AreSame(_mockSecundaryList[0], elementReturned);
    }

}