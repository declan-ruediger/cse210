from pathlib import Path

BASE_DIR: Path = Path(__file__).resolve().parent

def generate_class_file(folder: Path, class_name: str):
    with open(folder / f"{class_name}.cs", "w") as class_file:
        class_file.write(class_template_code.format(class_name, class_name))

class_template_code: str = """public class {}
{{
    private string exampleVar;

    public {}()
    {{

    }}

    public string ExampleFunction(int exampleInt)
    {{
        
    }}
}}"""

folder: Path = BASE_DIR / "week04" / "OnlineOrdering"

class_names_to_generate: list[str] = "Product, Customer, Address, Order".split(", ") # pyright: ignore[reportAssignmentType]

for class_name in class_names_to_generate:
    generate_class_file(folder, class_name)
