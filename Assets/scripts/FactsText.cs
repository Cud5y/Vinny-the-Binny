using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactsText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var FactText = GetComponent<Text> ();
        Debug.Log("hello" + "world");
        string[] Facts = {"Approximately 8 million pieces of plastic find their way into our oceans. That’s 2.92 x 10^8 pieces of plastic a year!",
        "269,000 tonnes of plastic are currently floating in the open ocean.",
        "Since the 1950s, around 8.3 billion tonnes of plastic have been produced worldwide, only 9% of it has been recycled.",
        "Worldwide, 8.3 billion tonnes have been produced since the 1950s, that’s equivalent to the weight of 800,000 Eiffel Towers.",
        "Worldwide, around 2 million plastic bags are used every minute.",
        "Plastic is killing 1.1 million seabirds and animals every year.",
        "The average time a plastic bag is used is 12 minutes, it then takes a thousand years to decompose.",
        "Enough plastic is thrown away each year to circle the Earth four times.",
        "Americans throw away 35 billion plastic bottles away every year.",
        "Approximately 500 billion plastic bags are used every year worldwide.",
        "It takes 500-1000 years for plastic to degrade.",
        "Some compounds in plastic have been found to alter hormones or have other human health effects.",
        "Off the coast of California, there is a “Great Pacific Garbage Patch.” This patch’s floating mass is twice the size of Texas, with plastic pieces outnumbering sea life six to one.",
        "The average American throws 185 pounds of plastic annually.",
        "73% of all worldwide litter is plastic.",
        "The average person consumes 70,000 microplastics every year.",
        "Over the past 50 years, plastic production has doubled.",
        "In some countries, using plastic is already illegal.",
        "Half of the world’s plastic is made in Asia.",
        "40% of plastic is used for packaging, a one time use.",
        "Over 90% of all seabirds have plastic waste in their stomach"};
        string Fact = Facts[Random.Range(0,Facts.Length)];
        Debug.Log(string.Format("Your actions have consequences. " + Fact));
        FactText.text = "Your actions have consequences. " + Fact;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
