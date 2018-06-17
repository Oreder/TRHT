function Diplome
  %X = dlmread('X.txt');
  %Y = dlmread('Y.txt');
  Z = dlmread('ThreadByFrequency.csv');
  
  figure
  surf(Z);
  grid on
end