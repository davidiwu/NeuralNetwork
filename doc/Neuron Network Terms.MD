
# neuron
	a cell that is specialized to conduct nerve impulses
	n.  神经原, 轴索, 神经细胞

# perceptron
	[计] 感知器
	
# sigmoid neuron
	a.  S字形的, 乙状结肠的, C字形的
	adj. curved in two directions (like the letter S)
	
# stochastic	
	adj.  being or having a random variable
	a.  随机的

# gradient
	n.  倾斜度, 梯度, 坡度, 斜率
	a.  渐升的, 渐降的, 步行的
	
# stochastic gradient descent: 
	the standard learning algorithm for neural networks


# perceptron:
	it is a type of artificial neuron
	it's a device that makes decisions by weighing up evidence
	A perceptron takes several binary inputs, x1,x2,…x1,x2,…, and produces a single binary output:

	
# How to compute the output:
	weights: w1, w2,..., real numbers expressing the importance of the respective inputs to the outputs
	neuron's output: 0 or 1, is determined by whether the weighted sum SUM(w1*x1 + w2*x2 + ...) 
		is less than or greater than some threshold value.
	threshold value: like the weights, is a real number which is a parameter of the neuron
		also known as the perceptron's bias, b = -threshold
	
	if SUM(w1*x1 + w2*x2 + ...) <= threshold value. then output = 0
	if SUM(w1*x1 + w2*x2 + ...) > threshold value. then output = 1
	
	let's simplify it:
		set: w * x = SUM(w1*x1 + w2*x2 + ...)
			 b = -threshold
			 
		if w*x + b <= 0 then output = 0
		if w*x + b > 0 then output = 1

# learning algorithms:
	it can automatically tune the weights and biases of a network of artificial neurons	
	This tuning happens in response to external stimuli, without direct intervention by a programmer
	

# Sigmoid neurons:
	Sigma: upper-case Σ, lower-case σ .
	they are similar to perceptrons, but modified so that small changes in their weights and bias cause only a small change in their output
	
# sigmoid neuron inputs:
	 it also has inputs like x1,x2,… But instead of being just 0 or 1, these inputs can also take on any values between 1 and 1. 
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
	In other words, when z=w*x+b is large and positive, the output from the sigmoid neuron is approximately 1, just as it would have been for a perceptron
	Suppose on the other hand that z=w*x+b is very negative. Then e−z→∞, and σ(z)≈0 . So when z=w*x+b is very negative, the behaviour of a sigmoid neuron also closely approximates a perceptron
	It's only when w*x+b is of modest size that there's much deviation from the perceptron model.
	
	
	If σ had in fact been a step function, then the sigmoid neuron would be a perceptron, since the output would be 1 or 0 depending on whether w*x+b was positive or negative	
	
it's the shape of σ  which really matters (smoothness), and not its exact form, then why use the particular form used for σσ in Equation (3)? In fact, later in the book we will occasionally consider neurons where the output is f(w*x+b) for some other activation function f(.).


	
	
	
