# Assembly Documentation Formater
Makes nice looking assembly documentation and formats comments in code to look neater!

## Example:
<pre>
############################################
#             Binary Search                #
############################################
# Input:                                   #
# $a0, array                               #
# $a1, left index                          #
# $a2, right index                         #
# $a3, item to search for                  #
############################################
# Output:                                  #
# $v0, index of the item (-1 if it failed) #
############################################
# Used Registers:                          #
# $t0, mid point                           #
# $t1, used in math                        #
############################################
</pre>
<pre>
############################################
#            End Binary Search             #
############################################
</pre>

## Options:
* Add Length: Allows you to add more spaces if you want them to fit a certain size globally
* Generate End Function: Generate end documentation for after the code

## Images:
![Assembly Documntation Formater](https://github.com/Pocable/AssemblyDocumentationFormater/blob/master/assemblyphoto.PNG?raw=true)
![Line Comment Spacer Tool](https://github.com/Pocable/AssemblyDocumentationFormater/blob/master/linecommentspacer?raw=true)
