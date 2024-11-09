import {Form, Formik} from 'formik'
import InputField from '../components/InputField'
import { CreatePoll } from '../services/poll-services'

export default function HomePage()
{
    const submit = async(data) => {
        try {
            await CreatePoll(data);
        } catch(error) {
            console.error(error)
        }
    }
    return (
        <div>
            <Formik initialValues={{name:"", options:[]}} onSubmit={(values)=>{submit(values)}}>
                <Form>
                    <InputField name="name" type="text" placeholder="Name"/>
                    <InputField name="name" type="text" placeholder="Options" />
                    <button type='submit'>
                        Submit
                    </button>
                </Form>
            </Formik>
        </div>
    )
}