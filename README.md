# Energetic Development

Your task is to design and code a simple simulation of the energetic industry that can be
used for testing its efficiency. 

There are three major categories of classes in this assignment:

Power Plants - they produce energy over time with use of resources:

- Coal Plant - produces 7 units of energy and consumes 100 units of coal per
day
- Solar Plant - produces 2 units of energy per day
- Nuclear Plant - produces 10 000 units of energy and consumes 1 unit of
uranium per day
- Fusion Plant - produces 20 000 units of energy and consumes 1 unit of
helium per day
- Annihilation Plant - produced 25 000 units of energy and consumes 1 unit of
antimatter per day

Mines - they produce resources over time:

- Coal Mine - produces 40 units of coal per day
- Uranium Mine - produces 100 units of uranium per day
- Moon Mine - produces 10 units of helium per day
- Hadron Collider - produces 1 unit of antimatter per week

Energy Consumers - they consume energy over time:

- World - consumes 6 000 000 units of energy per day
- Poland - consumes 40 000 units of energy per day
- New York - consumes 10 000 units of energy per day

Explanation about ‘units’:

- 1 energy unit is 1 MWh
- 1 coal unit is 1000 tons of coal
- 1 uranium unit is 100 kg of enriched uranium
- 1 helium unit is 100 kg of helium-3
- 1 antimatter unit is 1 gram of antimatter

It is recommended to create a ResourcesStorage class, in the Singleton pattern, that will
keep all the produced fuel and energy. As for creating sets of mines and plants for
simulations, implement the Factory pattern.

In your program, you configure the amount and types of energy plants and resource supplies
(for example: 1 nuclear plant, 10 coal plants, 100 coal mines, 1 uranium mine). Then, the
program tests whether the efficiency of the given setting (is this setting sufficient enough to
power New York? etc) by running a simulation of a 30 days cycle
