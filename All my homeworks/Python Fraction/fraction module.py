Python 3.9.1 (tags/v3.9.1:1e5d33e, Dec  7 2020, 17:08:21) [MSC v.1927 64 bit (AMD64)] on win32
Type "help", "copyright", "credits" or "license()" for more information.
>>> error = 0

def add(a,b):
    return normalize((a[0]*b[1]+b[0]*a[1],b[1]*a[1]))
    
def mul(a,b):
    return normalize((a[0]*b[0],a[1]*[1]))

def sub(a,b):
    return add(a,(-b[0],b[1]))

def div(a,b):
    return  mul(a,(b[1],b[0]))

def inp():
    a = length_check(map(int,input().split("/")))
    return create(a[0],a[1])
    
def normalize(a):
    return _reduce(sign_check(error_check(a)))

def create(m,n):
    return normalize(tuple(m,n))
    
def eq(a,b):
    return a[0]==b[0] and a[1]==b[1]
    
def it(a,b):
    return a[0]/a[1]==b[0]/b[1]
    
def _reduce(a):
    return tuple(a[0]/gcd(a[0],a[1]),a[1]/gcd(a[0],a[1]))

def GCD(x, y): 
   while(y): 
       x, y = y, x % y 
   return x
   
def sign_check(a):
    if a[1]<0 
        a[0]*-1
        a[1]*-1
    return a
    
def error_check(a):
    if len(a)!=2 or a[1]==0
        error = 1
        return (None,None)