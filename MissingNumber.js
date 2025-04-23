class NumberUtils {
    static getMaxValue(array) {
      return Math.max(...array);
    }
  
    static findMissingNumber(array) {
      const max = this.getMaxValue(array);
      for (let i = 0; i <= max; i++) {
        if (!array.includes(i)) {
          return i;
        }
      }
      return null; // If nothing is missing
    }
  }
  
  class MissingNumberService {
    constructor(numberArray) {
      this.numberArray = numberArray;
    }
  
    getMissingNumber() {
      return NumberUtils.findMissingNumber(this.numberArray);
    }
  }
  
  // Usage
  const nums = [9, 6, 4, 2, 3, 5, 7, 0, 1, 8, 11];
  const missingService = new MissingNumberService(nums);
  console.log(missingService.getMissingNumber());