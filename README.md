
# Dictionaries


With solving this problems, I practice working with Dictionaries.

## Problem: A Miner Task
You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on), and every even – quantity. Your task is to collect the resources and print them each on a new line. 

Print the resources and their quantities in format:

{resource} –> {quantity}

### Example:
#### input:
Gold

155

Silver

10

Copper

17

stop

#### output:
Gold -> 155

Silver -> 10

Copper -> 17

## Problem: Fix Emails
You are given a sequence of strings, each on a new line, until you receive the “stop” command. The first string is the name of a person. On the second line, you will receive their email. Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive).

 Print:
{name} – > {email} 

### Example:
#### input:
Ivan

ivanivan@abv.bg

Petar Ivanov

petartudjarov@mail.bg

Mike Tyson

myke@gmail.us

#### output:
Ivan -> ivanivan@abv.bg

Petar Ivanov -> petartudjarov@abv.bg

## Problem: Hands of Cards
You are given a sequence of people and for every person what cards he draws from the deck. The input will be separate lines in the format:

•	{personName}: {PT, PT, PT,… PT}

Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type.
 The input ends when a "JOKER" is drawn. The name can contain any ASCII symbol except ':'. 
 
 The input will always be valid and in the format described, there is no need to check it.
A single person cannot have more than one card with the same power and type, if they draw such a card they discard it. The people are playing with multiple decks. Each card has a value that is calculated by the power multiplied by the type. Powers 2 to 10 have the same value and J to A are 11 to 14. Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1).
Finally print out the total value each player has in his hand in the format:

•	{personName}: {value}

### Example:
#### input:
Joey: 2C, 4H, 9H, AS, QS

Monica: 3H, 10S, JC, KD, 5S, 10S

Ross: QH, QC, QS, QD

Monica: 6H, 7S, KC, KD, 5S, 10C

Ross: QH, QC, JS, JD, JC

Joey: JD, JD, JD, JD, JD, JD

JOKER

#### output:
Joey: 167

Monica: 175

Ross: 197

## Problem: Logs Aggregator
You are given a sequence of access logs in format <IP> <user> <duration>. For example:

•	192.168.0.11 peter 33

•	10.10.17.33 alex 12

•	10.10.17.35 peter 30

•	10.10.17.34 peter 120

•	10.10.17.34 peter 120

•	212.50.118.81 alex 46

•	212.50.118.81 alex 4

Write a program to aggregate the logs data and print for each user the total duration of his sessions and a list of unique IP addresses in format "<user>: <duration> [<IP1>, <IP2>, …]". Order the users alphabetically. Order the IPs alphabetically. In our example, the output should be the following:

•	alex: 62 [10.10.17.33, 212.50.118.81]

•	peter: 303 [10.10.17.34, 10.10.17.35, 192.168.0.11]











