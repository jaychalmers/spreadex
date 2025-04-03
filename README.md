# spreadex

- Used signed ints for x/y coordinates - didn't know whether to assume cornered or centered axes.
- There is a mismatch between the name of the square width property, and how it is presented in it's draw method ("size"). This is consistent with the brief, but noted.
- In a more complex project, I might have dedicated classes for rendering each widget subtype, but in this case handling it in a switch was fine
- String rendering - personally, I'm quite a fan of {0} {1} type notation - it's just easier for my brain to follow. Nobody seems to agree with me so I've got for the template type evaluation
- inconsistencies in output (varying spaces between equals and so on) are copied from brief verbatim
- old skool inheritance on textbox, but in this case I couldn't see a reason not to. I'd consider using composition instead, but it made some of the abstract properties on Widget a bit fiddly so I left it for now