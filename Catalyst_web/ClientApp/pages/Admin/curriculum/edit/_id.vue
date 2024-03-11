<template>
  <div>
    <form @submit.prevent="submitForm" :action="`/api/Courses/Edit/${courseId}`">
      <div class="form-group container">
        <div class="row">
          <div class="col">
            <label for="titleArm">Title in Armenian</label>
            <input v-model="createData.titleArm" type="text" id="titleArm" placeholder="Title in Armenian" name="titleArm">
          </div>

          <div class="col">
            <label for="titleEng">Title in English</label>
            <input v-model="createData.titleEng" type="text" id="titleEng" placeholder="Title in English" name="titleEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="descriptionArm">Description in Armenian</label>
            <textarea rows="4" cols="50" v-model="createData.descriptionArm" id="descriptionArm" placeholder="Description in Armenian" name="descriptionArm"></textarea>
          </div>

          <div class="col">
            <label for="descriptionEng">Description in English</label>
            <textarea rows="4" cols="50" v-model="createData.descriptionEng" id="descriptionEng" placeholder="Description in English" name="descriptionEng"></textarea>
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="curriculumArm">Curriculum in Armenian</label>
            <textarea rows="4" cols="50" v-model="createData.curriculumArm" id="curriculumArm" placeholder="Curriculum in Armenian" name="curriculumArm"></textarea>
          </div>

          <div class="col">
            <label for="curriculumEng">Curriculum in English</label>
            <textarea rows="4" cols="50" v-model="createData.curriculumEng" id="curriculumEng" placeholder="Curriculum in English" name="curriculumEng"></textarea>
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="categoryEng">Category in Armenian</label>
            <input v-model="createData.categoryEng" id="categoryEng" placeholder="Category in Armenian" name="categoryEng">
          </div>

          <div class="col">
            <label for="categoryArm">Category in English</label>
            <input v-model="createData.categoryArm" id="categoryArm" placeholder="Category in English" name="categoryArm">
          </div>
        </div>

        <div class="row">
          <div class="col-4">
            <label for="studentsCountOnCurriculum">Students Count Of Curriculum</label>
            <input v-model="createData.studentsCountOnCurriculum" id="studentsCountOnCurriculum" placeholder="students Count Of Curriculum" name="studentsCountOnCurriculum">
          </div>

          <div class="col-4">
            <label for="lectures">curriculum Title in Armenian</label>
            <input v-model="createData.curriculumDescriptionTitleArm" id="curriculumDescriptionTitleArm" placeholder="curriculum Title in Armenian" name="curriculumDescriptionTitleArm">
          </div>

          <div class="col-4">
            <label for="curriculumDescriptionTitleEng">curriculum Title in English</label>
            <input v-model="createData.curriculumDescriptionTitleEng" id="curriculumDescriptionTitleEng" placeholder="curriculum Title in English" name="curriculumDescriptionTitleEng">
          </div>
        </div>

        <div class="row">
          <div class="col-4">
            <label for="duration">duration</label>
            <input v-model="createData.duration" id="duration" placeholder="duration" name="duration">
          </div>

          <div class="col-4">
            <label for="lectures">lectures count</label>
            <input v-model="createData.lectures" id="lectures" placeholder="lectures Count" name="lectures">
          </div>

          <div class="col-4">
            <label for="students">Students Count</label>
            <input v-model="createData.students" id="students" placeholder="Students Count" name="students">
          </div>
        </div>

        <div class="row">
          <div class="col-4">
            <label for="skillLevel">skillLevel</label>
            <input v-model="createData.skillLevel" id="skillLevel" placeholder="skillLevel" name="skillLevel">
          </div>

          <div class="col-4">
            <label for="language">language</label>
            <input v-model="createData.language" id="language" placeholder="language" name="language">
          </div>

          <div class="col-4">
            <label for="rating">rating</label>
            <input v-model="createData.rating" id="rating" type="number" placeholder="rating" name="rating">
          </div>
        </div>
        <client-only>
          <div class="row">
            <div class="col">
              <label for="startDate">Start Date</label>
              <b-form-datepicker id="datepicker-full-width"
                                 v-model="createData.startDate"
                                 :show-decade-nav="showDecadeNav"
                                 :hide-header="hideHeader"
                                 class="mb-2"
                                 placeholder="Choose a date"
                                 menu-class="w-80"
                                 calendar-width="100%">
              </b-form-datepicker>
            </div>

            <div class="col">
              <label for="endDate">End Date</label>
              <b-form-datepicker id="example-i18n-picker2"
                                 v-model="createData.endDate"
                                 :show-decade-nav="showDecadeNav"
                                 :hide-header="hideHeader"
                                 class="mb-2"
                                 placeholder="Choose a date"
                                 menu-class="w-80"
                                 calendar-width="100%">
              </b-form-datepicker>
            </div>
          </div>
        </client-only>

        <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
      </div>
    </form>
  </div>
</template>

<script>
  import https from 'https';

  export default {
    name: 'EditCurriculum',
    data() {
      return {
        value: '',
        showDecadeNav: true,
        hideHeader: true
      }
    },
    data() {
      return {
        curriculumId: null,
        createData: { titleArm: '', titleEng: '', descriptionArm: '', descriptionEng: '', startDate: '', endDate: '', categoryEng: '', categoryArm: '', curriculumEng: '', curriculumArm: '', duration: '', lectures: '', students: '', skillLevel: '', language: '', studentsCountOnCurriculum: '', rating: '', curriculumDescriptionTitleEng: '', curriculumDescriptionTitleArm: '' },
      };
    },
    async created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }

      // Check if a course ID is provided in the route parameters
      if (this.$route.params.id) {
        this.curriculumId = this.$route.params.id;
        await this.fetchCourseDetails();
      }
    },
    methods: {
      async fetchCourseDetails() {
        try {
          const response = await this.$axios.get(`/api/CurriculumDetails/${this.curriculumId}`);
          this.createData = { ...response.data };
        } catch (error) {
          console.error('Error fetching Curriculum details:', error);
        }
      },
      async submitForm() {
        try {
          const response = await this.$axios.put(`/api/Curriculums/Edit/${this.curriculumId}`, this.createData);
          console.log("response", response);
          if (response) {
            this.$toasted.success('Edit successful!');
            // Redirect after a successful edit
            window.location = "/admin/curriculum/list";
          }
        } catch (error) {
          // Handle error and display message
          this.$toasted.error('An error occurred. Please try again.');
        }
      },
    },
  };
</script>

<style scoped>
  .form-control {
    height: auto !important;
  }
  .form-group {
    margin-bottom: 20px;
  }

  .row {
    display: flex;
    justify-content: space-between;
    margin-bottom: 10px;
  }

  .col {
    flex: 0 0 48%; /* Adjust the width as needed */
  }

  label {
    display: block;
    margin-bottom: 5px;
    font-weight: bold;
  }

  input,
  textarea,
  select {
    width: 100%;
    padding: 8px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
    margin-top: 5px;
  }
</style>
