# -*- coding: utf-8 -*-
"""
Created on Wed Sep 22 09:18:04 2021

@author: Miguel
"""

from pyswip import Prolog
prolog = Prolog()
prolog.assertz("padre(juan,maria)")
prolog.assertz("padre(pablo,juan)")
prolog.assertz("padre(pablo,marcela)")
prolog.assertz("padre(carlos,debora)")
list(prolog.query("padre(X,Y)"))  == [{'X'},{'Y'}]
for element in prolog.query("padre(X,Y)"):
    print(element ["X"], "es el padre de", element["Y"])