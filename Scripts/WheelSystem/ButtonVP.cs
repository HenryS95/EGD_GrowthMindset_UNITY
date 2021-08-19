using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVP : MonoBehaviour
{

    [SerializeField] private Animator buttonAnimator;

    [SerializeField] private Animator wheelAnimator;

    [SerializeField] private Animator connectNeuron1;
    [SerializeField] private Animator connectNeuron2;
    [SerializeField] private Animator connectNeuron3;
    [SerializeField] private Animator connectNeuron4;
    [SerializeField] private Animator connectNeuron5;
    [SerializeField] private Animator connectNeuron6;

    [SerializeField] private Animator electricalImpulse;

    [SerializeField] private Animator lastWords;

    [SerializeField] private ParticleSystem particlesCount;

    private int wheelInt;

    public void OnPress()
    {
        //triggers button animation
        buttonAnimator.SetTrigger("ButtonTrigger");

        //trigger wheel spin each time button is pressed greater than 3 returns to 0
        wheelInt += 1;

        wheelInt = wheelInt % 4;

        wheelAnimator.SetInteger("intWheel", wheelInt);


        //triggers neuron activity depending on interger values
        if (wheelInt == 0)
        {

            FindObjectOfType<AudioManager>().Play("WOTnoBuzz");

            var main = particlesCount.main;
            main.maxParticles = 5;

        }


        if (wheelInt == 1)
        {
            FindObjectOfType<AudioManager>().Play("WOTwithBuzz");

            connectNeuron1.SetTrigger("NeuronConnection");
            connectNeuron2.SetTrigger("NeuronConnection2");
            connectNeuron3.SetTrigger("NeuronConnection3");
            connectNeuron4.SetTrigger("NeuronConnection4");
            connectNeuron5.SetTrigger("NeuronConnection5");
            connectNeuron6.SetTrigger("NeuronConnection6");

            electricalImpulse.SetTrigger("electricalImpulse");

            var main = particlesCount.main;
            main.maxParticles = 20;
        }

        if (wheelInt == 2)
        {

            FindObjectOfType<AudioManager>().Play("WOTwithBuzz");

            connectNeuron1.SetTrigger("NeuronConnection");
            connectNeuron2.SetTrigger("NeuronConnection2");
            connectNeuron3.SetTrigger("NeuronConnection3");
            connectNeuron4.SetTrigger("NeuronConnection4");
            connectNeuron5.SetTrigger("NeuronConnection5");
            connectNeuron6.SetTrigger("NeuronConnection6");

            electricalImpulse.SetTrigger("electricalImpulse");

            var main = particlesCount.main;
            main.maxParticles = 35;

        }

        if (wheelInt == 3)
        {

            FindObjectOfType<AudioManager>().Play("WOTnoBuzz");

            var main = particlesCount.main;
            main.maxParticles = 100;

            lastWords.SetTrigger("lastWords");

        }
    }
}

