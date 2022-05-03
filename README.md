# Labb3.API

## Hämta alla personer i systemet - 

GET https://localhost:44383/api/persons/


## Hämta alla intressen kopplade till en person - 

GET https://localhost:44383/api/persons/2/interest (2 = personens ID)


## Hämta alla länkar kopplade till en viss person - 

GET https://localhost:44383/api/persons/2/link 


## Koppla en person till ett nytt intresse samt URL - 

POST https://localhost:44383/api/persons/
1. Body => Raw => JSON
2. Till exempel: 
{
    "Title": "Skiing",
    "Description": "Making 360s",
    "Url": "https:\\www.skistar.com",
    "PersonId": 3
}

## Lägga till nya länkar för specifik person samt intresse - 

POST https://localhost:44383/api/persons/attachLink
1. Body => Raw => JSON
2. Till exempel: 
{
    "InterestId": 4,
    "url": "https:\\www.chess.com"
}
