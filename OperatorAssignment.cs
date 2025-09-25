# Print the program title
print("Anonymous Income Comparison Program\n")

# Gather input for Person 1
print("Person 1")
# Ask for hourly rate and convert input to float
hourly_rate_1 = float(input("Hourly Rate? "))
# Ask for hours worked per week and convert input to float
hours_per_week_1 = float(input("Hours worked per week? "))

# Gather input for Person 2
print("\nPerson 2")
# Ask for hourly rate and convert input to float
hourly_rate_2 = float(input("Hourly Rate? "))
# Ask for hours worked per week and convert input to float
hours_per_week_2 = float(input("Hours worked per week? "))

# Calculate annual salary for Person 1
# Assuming 52 working weeks in a year
annual_salary_1 = hourly_rate_1 * hours_per_week_1 * 52

# Calculate annual salary for Person 2
annual_salary_2 = hourly_rate_2 * hours_per_week_2 * 52

# Display annual salaries
print("\nAnnual salary of Person 1:")
print(annual_salary_1)

print("\nAnnual salary of Person 2:")
print(annual_salary_2)

# Compare salaries and display result
print("\nPerson 1 makes more money than Person 2")
print(annual_salary_1 > annual_salary_2)
