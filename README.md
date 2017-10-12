# NeuroNetwork

	1. using c# to demonstrate the back-propagation method for neuron network training
	2. for activation function, here uses sigmoid function. 
	3. below shows the difference between sigmoid neuron and perceptron.

# Train the network

	demostrate how to train the network to act as an XOR / XAND function:

	xor function:
  		0 xor 0 = 0;  0 xor 1 = 1; 1 xor 0 = 1; 1 xor 1 = 0;

	xand function: 
 		0 xand 0 = 1;  0 xand 1 = 1; 1 xand 0 = 1; 1 xand 1 = 0;


# Sigmoid neurons:

	Sigma: upper-case Σ, lower-case σ .
	they are similar to perceptrons, but modified so that small changes in their weights and bias 
	cause only a small change in their output
	
# sigmoid neuron inputs:

	it also has inputs like x1,x2,… But instead of being just 0 or 1, 
	these inputs can also take on any values between 1 and 1. 
	So, for instance, 0.638…is a valid input for a sigmoid neuron.	
	 
	sigmoid neuron has weights for each input, w1,w2,… and an overall bias, b.
	 
# sigmoid neuron output:

	But the output is not 0 or 1. Instead, it's σ(w*x+b), where σ (Sigma) is called	sigmoid function. 
				1
	σ(z)≡----------------------------
			1 + e^(−z)
	
	the output of a sigmoid neuron with inputs x1,x2,… weights w1,w2,… and bias b is
			1
	------------------
	1 + exp⁡(−∑jwjxj−b)

# Similarity to the perceptron and sigmoid neuron:

	suppose z≡w*x+b is a large positive number. Then e−z≈0 and so σ(z)≈1 .
	
	In other words, when z=w*x+b is large and positive, the output from the sigmoid neuron is approximately 1, 
	just as it would have been for a perceptron
	
	Suppose on the other hand that z=w*x+b is very negative. Then e−z→∞, and σ(z)≈0 . 
	So when z=w*x+b is very negative, the behaviour of a sigmoid neuron also closely approximates a perceptron
	
	It's only when w*x+b is of modest size that there's much deviation from the perceptron model.
	
	
	If σ had in fact been a step function, then the sigmoid neuron would be a perceptron, 
	since the output would be 1 or 0 depending on whether w*x+b was positive or negative	
	
