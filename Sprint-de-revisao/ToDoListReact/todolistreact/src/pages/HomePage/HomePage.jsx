import { NewTaskButton } from "../../components/Buttons/Buttons";
import Container from "../../components/Container/Container";
import { MainInput } from "../../components/Inputs/Inputs";
import MainContent from "../../components/MainContent/MainContent";
import { MainTitle } from "../../components/Titles/Titles";


function HomePage() {
  return (
    <MainContent>
      
      <Container>

        <MainTitle dayText={"Terça Feira,"} day={"26"} month={"Julho"}/>

        <MainInput/>

      </Container>

      <NewTaskButton/>

    </MainContent>
  );
}

export default HomePage;
