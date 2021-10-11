Implement the IsValid function to validate the checksum based on the rules below.

A checksum needs to be calculated to validate that an account number is valid.
The checksum is calculated as follows:
1. Each consecutive pair of digits in the account number is added together and the least significant digit of the result is appended to a new number
2. This process is repeated until the length of the new number is reduced to 1 digit.
3. This final digit should equal the last digit (Check Digit) of the original number.

As An example: 
Original Value: 82345
Check Digit: 5 (Last digit of the number)

Calculation:
8   2   3   4   5
 \+/ \+/ \+/ \+/
  0   5   7   9    ---> 8 + 2 = 10: The least significant digit of 10 is "0"
   \+/ \+/ \+/                          
    5   2   6
     \+/ \+/ 
      7   8
       \+/
        5  ---> The Final digit matches the Check digit                               
                            
Include any other necessary validation.
