.data
message: .asciiz "Hello World!"

.text
main:
  la $a0, message # Load helloworld string into register $a0
  li $v0 4 # Load print string syscommand
  syscall # Print the string
  jr $ra # Return
