class RandomizedSet:

    def __init__(self):
        self.randomizedSet = set()
    def insert(self, val: int) -> bool:
        if val not in self.randomizedSet:
            self.randomizedSet.add(val)
            return True
        return False
    def remove(self, val: int) -> bool:
        if val in self.randomizedSet:
            self.randomizedSet.discard(val)
            return True
        return False
    def getRandom(self) -> int:
        return random.choice(list(self.randomizedSet))