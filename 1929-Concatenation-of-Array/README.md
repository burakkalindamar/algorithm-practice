<h1> Problem Statement </h1>

<h2> Title: Concatenation of Array </h2>
<h3> Difficulty: Easy </h3>
<h3> Topics: Arrays </h3>
<h3> Companies: Not specified </h3>

<p>Given an integer array <code>nums</code> of length <code>n</code>, you want to create an array <code>ans</code> of length <code>2n</code> where <code>ans[i] == nums[i]</code> and <code>ans[i + n] == nums[i]</code> for <code>0 <= i < n</code> (0-indexed).</p>

<p>Specifically, <code>ans</code> is the concatenation of two <code>nums</code> arrays.</p>

<p>Return the array <code>ans</code>.</p>

<h3> Example </h3>
<p><strong>Input:</strong> 
<code>nums = [1,2,1]</code>
</p>
<p><strong>Output:</strong> 
<code>[1,2,1,1,2,1]</code>
</p>
<p><strong>Explanation:</strong> 
The array <code>ans</code> is formed as follows:
<ul>
<li><code>ans = [nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]</code></li>
<li><code>ans = [1,2,1,1,2,1]</code></li>
</ul>
</p>

<p><strong>Input:</strong> 
<code>nums = [1,3,2,1]</code>
</p>
<p><strong>Output:</strong> 
<code>[1,3,2,1,1,3,2,1]</code>
</p>
<p><strong>Explanation:</strong> 
The array <code>ans</code> is formed as follows:
<ul>
<li><code>ans = [nums[0],nums[1],nums[2],nums[3],nums[0],nums[1],nums[2],nums[3]]</code></li>
<li><code>ans = [1,3,2,1,1,3,2,1]</code></li>
</ul>
</p>

<h3> Constraints </h3>
<ul>
<li><code>n == nums.length</code></li>
<li><code>1 <= n <= 1000</code></li>
<li><code>1 <= nums[i] <= 1000</code></li>
</ul>